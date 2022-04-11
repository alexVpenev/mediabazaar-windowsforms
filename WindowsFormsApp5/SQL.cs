using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp5
{
    sealed class SQL
    {
        private DBConnection dbc;
        private MySqlConnection con;
        private MySqlConnection bon;
        public SQL()
        {
            try
            {
                dbc = new DBConnection();
                con = new MySqlConnection(dbc.ConnString);
                bon = new MySqlConnection(dbc.ConnString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }

        private void CheckConnection()
        {
            if (!con.Ping())
                con.Open();
        }
        
        public List<User> GetUsers()
        {
            try
            {
                List<User> users = new List<User>();
                bon.Open();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM userprofile;", bon);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Enum.TryParse(rd.GetValue(2).ToString(), out ACCESS acc);
                    User user = new User(rd.GetValue(0).ToString(), rd.GetValue(1).ToString(), acc);
                    users.Add(user);
                }
                return users;
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                bon.Close();
            }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                bon.Open();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee;", bon);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Employee e = new Employee(Convert.ToInt32(rd.GetValue(0)), rd.GetValue(1).ToString(), rd.GetValue(2).ToString(), rd.GetValue(3).ToString(),
                        DateTime.Parse(rd.GetValue(4).ToString()), rd.GetValue(5).ToString(), rd.GetValue(6).ToString(), Convert.ToBoolean(rd.GetValue(7)),
                        rd.GetValue(8).ToString(), Convert.ToBoolean(rd.GetValue(9)), Convert.ToDouble(rd.GetValue(10)), Convert.ToDouble(rd.GetValue(11)),
                         rd.GetValue(12).ToString(), Convert.ToInt32(rd.GetValue(13)), rd.GetValue(14).ToString(), rd.GetValue(15).ToString(), rd.GetValue(16).ToString());
                    employees.Add(e);
                }
                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                bon.Close();
            }

        }

        public List<Shift> GetAllShifts()
        {
            try
            {
                List<Shift> shifts = new List<Shift>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT Employee_ID, ShiftDate, ShiftTime, Shift_ID From shift", con);
                rd = cmd.ExecuteReader();
                List<Employee> list = GetEmployees();
                while (rd.Read())
                {
                    Enum.TryParse(rd.GetValue(2).ToString(), out SHIFTTYPE time);
                    DateTime t = DateTime.Parse(rd.GetValue(1).ToString());
                    int id = Convert.ToInt32(rd.GetValue(3).ToString());
                    //Employee e = GetEmployeeByID(rd.GetValue(0).ToString());
                    Employee e;

                    foreach (Employee a in list)
                    {
                        if (a.id == Convert.ToInt32(rd.GetValue(0)))
                        {
                            e = a;
                            shifts.Add(new Shift(e, id, t, time));
                        }
                    }

                }
                return shifts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        // TODO: @Alex - double check.
        //public List<Shift> GetAllShifts()
        //{
        //    try
        //    {
        //        List<Shift> shifts = new List<Shift>();
        //        con.Open();
        //        MySqlDataReader rd;
        //        MySqlCommand cmd = new MySqlCommand("SELECT employee.FirstName, employee.LastName, shift.ShiftDate, shift.ShiftTime " +
        //            "FROM employee INNER JOIN shift ON employee.Employee_ID = shift.Employee_ID;", con);
        //        rd = cmd.ExecuteReader();
        //        while (rd.Read())
        //        {
        //            Enum.TryParse(rd.GetValue(3).ToString(), out SHIFTTYPE time);
        //            DateTime t = DateTime.Parse(rd.GetValue(2).ToString());
        //            string s = rd.GetValue(0).ToString() + rd.GetValue(1).ToString();
        //            Shift shift = new Shift(s, t, time);
        //            shifts.Add(shift);
        //        }
        //        rd.Close();
        //        con.Close();
        //        return shifts;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        throw ex;
        //    }
        //}

        public void CreateShift(int id, string date, string time)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `shift` (`Employee_ID`, `Shift_ID`, `ShiftDate`, `ShiftTime`) VALUES ('" + id +"', NULL, '" + date + "', '" + time.ToString() + "');", con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public bool CheckIfPersonIsScheduled(int id, DateTime dt)
        {
            try
            {
                con.Open();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM shift WHERE Employee_ID=" + id + " AND ShiftDate='" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "';", con);
                rd = cmd.ExecuteReader();

                if(rd.HasRows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }


        }

        public bool CheckIfPersonIsAvailable(int id, DateTime dt)
        {
            try
            {
                con.Open();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM availability WHERE Employee_ID = " +id + " AND AvailabilityDate = '"+ dt.ToString("yyyy-MM-dd HH:mm:ss") +"';", con);
                rd = cmd.ExecuteReader();

                return rd.Read();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }


        }

        public int GetShiftIDFromEmployeeInfo(string EmployeeName, string date, string time)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                /*e.FirstName + ' ' + e.LastName as name,*/
                MySqlCommand cmd = new MySqlCommand("SELECT s.Shift_ID FROM employee as e INNER JOIN shift as s ON e.Employee_ID = s.Employee_ID WHERE e.FirstName + e.LastName = '" + EmployeeName+ "' AND s.ShiftDate = '" +date+ "' AND s.ShiftTime = '" +time+ "'", con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int i = Convert.ToInt32(rd.GetValue(0));
                    return i;
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteShift(int shiftID)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("DELETE FROM shift WHERE shift.Shift_ID = " + shiftID + "", con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        public int GetEmployeeIdFromName(string name)
        {
            try
            {
                this.CheckConnection();
                int i = 0;
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("Select Employee_ID FROM employee WHERE CONCAT(FirstName, LastName) ='" + name + "'", con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    i = Convert.ToInt32(rd.GetValue(0));
                    MessageBox.Show(i.ToString());
                }
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void CreateShift(int id, DateTime date, SHIFTTYPE time)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO shift (Employee_ID, Shift_ID, ShiftDate, ShiftTime)" +
                    "VALUES ('" + id + "', NULL, '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + time + "' )", con);
                rd = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddEmployee(Employee e)
        {
            try
            {
                string c = e.dateOfBirth.ToString("yyyy-MM-dd");
                this.CheckConnection();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp.InsertCommand = new MySqlCommand(String.Format("INSERT INTO employee (FirstName, LastName, Email, DateOfBirth, Phone, Address, MaritalStatus," +
                    "BSN, Fulltime, FTE, HourlyWage, EmergencyContact, DepartmentID, DepartmentName, Position, Password) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', {8}, {9}, {10}, '{11}', {12}, '{13}', '{14}', '{15}');", e.firstName, e.lastName, e.emailAddress,
                    c, e.phoneNo, e.address, e.maritalStatus, e.BSN, e.fulltime, e.FTE, e.salary, e.emergencyNo, e.departmentId, e.departmentName, e.position, e.password), con);
                adp.InsertCommand.ExecuteNonQuery();
                adp.InsertCommand.Dispose();
                adp.InsertCommand = new MySqlCommand(String.Format("INSERT INTO contract(EmployeeID, Active, StartDate) values ({0}, {1}, '{2}' );", e.id, true, DateTime.Today.ToString("yyyy-MM-dd")), con);
                adp.InsertCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = new List<Product>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM product;", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Enum.TryParse(rd.GetValue(6).ToString(), out Department category);

                    Product p = new Product(rd.GetValue(0).ToString(), rd.GetValue(1).ToString(), Convert.ToDouble(rd.GetValue(2)), Convert.ToDouble(rd.GetValue(3)), Convert.ToDouble(rd.GetValue(4)), rd.GetValue(5).ToString(), category, Convert.ToDouble(rd.GetValue(7)), Convert.ToInt32(rd.GetValue(8)), Convert.ToInt32(rd.GetValue(9)), Convert.ToInt32(rd.GetValue(10)), rd.GetValue(11).ToString(), Convert.ToInt32(rd.GetValue(12)), DateTime.Parse(rd.GetValue(13).ToString()), rd.GetValue(14).ToString());
                    products.Add(p);
                }
                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public Employee GetEmployeeByID(string id)
        {

            try
            {
                bon.Open();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE Employee_ID = '" + id + "';",bon);
                rd = cmd.ExecuteReader();
                rd.Read();
                Employee e = new Employee(Convert.ToInt32(rd.GetValue(0)), rd.GetValue(1).ToString(), rd.GetValue(2).ToString(), rd.GetValue(3).ToString(),
                    DateTime.Parse(rd.GetValue(4).ToString()), rd.GetValue(5).ToString(), rd.GetValue(6).ToString(), Convert.ToBoolean(rd.GetValue(7)),
                    rd.GetValue(8).ToString(), Convert.ToBoolean(rd.GetValue(9)), Convert.ToDouble(rd.GetValue(10)), Convert.ToDouble(rd.GetValue(11)),
                    rd.GetValue(12).ToString(), Convert.ToInt32(rd.GetValue(13)), rd.GetValue(14).ToString(), rd.GetValue(15).ToString(), rd.GetValue(16).ToString());
                bon.Close();
                return e;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Employee GetEmployeeByBSN(string bsn)
        {

            try
            {
                con.Open();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE BSN = '" + bsn + "';", con);
                rd = cmd.ExecuteReader();
                rd.Read();
                Employee e = new Employee(Convert.ToInt32(rd.GetValue(0)), rd.GetValue(1).ToString(), rd.GetValue(2).ToString(), rd.GetValue(3).ToString(),
                    DateTime.Parse(rd.GetValue(4).ToString()), rd.GetValue(5).ToString(), rd.GetValue(6).ToString(), Convert.ToBoolean(rd.GetValue(7)),
                    rd.GetValue(8).ToString(), Convert.ToBoolean(rd.GetValue(9)), Convert.ToDouble(rd.GetValue(10)), Convert.ToDouble(rd.GetValue(11)),
                    rd.GetValue(12).ToString(), Convert.ToInt32(rd.GetValue(13)), rd.GetValue(14).ToString(), rd.GetValue(15).ToString(), rd.GetValue(16).ToString());
                con.Close();
                return e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Shelf> GetShelves()
        {
            try
            {
                List<Shelf> shelves = new List<Shelf>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM shelf;", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Shelf s = new Shelf(Convert.ToInt32(rd.GetValue(0)), Convert.ToInt32(rd.GetValue(2)), Convert.ToInt32(rd.GetValue(3)), rd.GetValue(1).ToString());
                    shelves.Add(s);
                }
                rd.Close();
                con.Close();
                return shelves;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateEmployee(Employee e)
        {
            string c = e.dateOfBirth.ToString("yyyy-MM-dd");
            try
            {
                this.CheckConnection();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp.UpdateCommand = new MySqlCommand("Update employee SET FirstName = '" + e.firstName + "', LastName = '" + e.lastName + "', Email = '" + e.emailAddress + "', " +
                    "DateOfBirth = '" + c + "', Phone = '" + e.phoneNo + "', Address = '" + e.address + "', MaritalStatus = " + e.maritalStatus + ", BSN = '" + e.BSN + "', Fulltime = " + e.fulltime + ", " +
                    "FTE = " + e.FTE + ", HourlyWage = " + e.salary + ", EmergencyContact='" + e.emergencyNo + "', DepartmentID =" + e.departmentId + ", DepartmentName = '" + e.departmentName + "', Position = '" + e.position + "'WHERE Employee_ID = " + e.id + ";", con);
                adp.UpdateCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Product> GetShelfIdForProduct()
        {
            try
            {
                List<Product> products = new List<Product>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT product.Model, product.BrandName, product.Price, product.AisleNumber, product.NumberInWarehouse, shelf.ShelfID FROM product INNER JOIN shelf ON product.Model = shelf.ProductModel", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Product productInfo = new Product(rd.GetValue(0).ToString(), rd.GetValue(1).ToString(), Convert.ToDouble(rd.GetValue(2)), Convert.ToInt32(rd.GetValue(4)), Convert.ToInt32(rd.GetValue(3)), rd.GetValue(5).ToString());
                    products.Add(productInfo);
                }
                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public string[] GetContractsStatus()
        {
            try
            {
                List<string> contracterinos = new List<string>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT Active FROM contract;", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    contracterinos.Add(rd.GetValue(0).ToString());
                }
                return contracterinos.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Contract> GetContracts()
        {
            try
            {
                List<Contract> contracterinos = new List<Contract>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT* FROM contract;", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Contract c;
                    if(rd.GetValue(5).ToString() == "")
                    {
                        c = new Contract(Convert.ToInt32(rd.GetValue(0)), Convert.ToInt32(rd.GetValue(1)), Convert.ToBoolean(rd.GetValue(2)),
                        DateTime.Parse(rd.GetValue(3).ToString()), DateTime.MinValue, "");
                    }
                    else
                    {
                        c = new Contract(Convert.ToInt32(rd.GetValue(0)), Convert.ToInt32(rd.GetValue(1)), Convert.ToBoolean(rd.GetValue(2)),
                        DateTime.Parse(rd.GetValue(3).ToString()), DateTime.Parse(rd.GetValue(4).ToString()), rd.GetValue(5).ToString());
                    }
                    contracterinos.Add(c);
                }
                return contracterinos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddProduct(string model, string brand, double weight, double height, double width, string description, Department category, double price, int aisleNumber, int locationLeft, int locationRight, string registeringEmployee, int noInWarehouse, DateTime shipmentDate)
        {
            DateTime shipDate = shipmentDate;
            if (shipmentDate == null)
            {
                shipDate = DateTime.Now;
            }
            else shipDate = shipmentDate;

            try
            {
                string d = shipmentDate.ToString("yyyy-MM-dd 00:00:00");
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO product (Model, BrandName, Weight, Height, Width, Description, Category, Price, AisleNumber, LocationLeftSide, LocationRightSide, RegistiringEmployee, NumberInWarehouse, ShipmentDate)" +
                    "VALUES (" + "'" + model + "'"+ ", "+ "'" + brand + "'"+ ", " + weight + ", " + height + ", " + width + ", "+ "'" + description + "'" + ", "+ "'" + category + "'" +  ", " + price + ", " + aisleNumber + ", " + locationLeft + ", " + locationRight + ", " +"'" + registeringEmployee + "'"+ ", " + noInWarehouse + ", " + "'" + d +"'" + " );", con);
     

                rd = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void EditProduct(string brand, int price, int quantity, int aisleNr, string id)
        {          
            //where model = selected item
            //id = model
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("UPDATE product SET BrandName ='" + brand + "', Price =" + price + ", AisleNumber =" + aisleNr + ", NumberInWarehouse =" + quantity + " WHERE Model = '" + id + "';", con) ;
                
                rd = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void AddShelf(string model, int limit, int noInWarehouse)
        {
            limit = 20;
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO shelf (ProductModel, ShelfLimit, NoOfProducts" + "VALUES ( '" + model + "'" + ", " + limit + ", " + noInWarehouse + " );", con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void FireEmployee(Employee e, string reason)
        {
            try
            {
                this.CheckConnection();
                MySqlDataAdapter adp = new MySqlDataAdapter();
                adp.UpdateCommand = new MySqlCommand("Update contract SET Active = " + 0 + ", EndDate = '" + DateTime.Now.ToString("yyyy-MM-dd")
                    +"', ReasonForEnding='" + reason + "'  WHERE EmployeeID = " + e.id + ";", con);
                adp.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void RemoveProduct(string id)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("DELETE FROM product WHERE Model = '" + id + "'; ", con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void MakeRequest(string model, int quantity, string status)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO stockrequest (ProductModel, Quantity, RequestStatus) VALUES ('" + model + "'," + quantity +", '" + status + "' );", con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Request> GetRequests()
        {
            try
            {
                List<Request> requests = new List<Request>();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT RequestNo, ProductModel, Quantity, RequestStatus FROM stockrequest;", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //Enum.TryParse(rd.GetValue(3).ToString(), out Status status);

                    Request r = new Request(Convert.ToInt32(rd.GetValue(0)), rd.GetValue(1).ToString(), Convert.ToInt32(rd.GetValue(2)), rd.GetValue(3).ToString());
                    requests.Add(r);
                }
                return requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void AcceptRequest(int id)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("UPDATE stockrequest SET RequestStatus = 'ACCEPTED' WHERE RequestNo = " + id + ";", con);
                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeclineRequest(int id)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("UPDATE stockrequest SET RequestStatus = 'DECLINED' WHERE RequestNo = " + id + ";", con);

                rd = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateQuantity(string model,int quantity)
        {
            try
            {
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("UPDATE product SET product.NumberInWarehouse = product.NumberInWarehouse -"+ quantity+" WHERE product.Model = '" + model + "';", con);
                rd = cmd.ExecuteReader();

                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddAttendance(string username, string type, DateTime dateTime, string comment)
        {
            try
            {
                string d = dateTime.ToString("yyyy-MM-dd hh:mm:ss");
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO attendance (Username, Type, Date, Comment)" +
                    "VALUES ('" + username + "','" + type + "','" + d + "','"+ comment +"');", con);


                rd = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Attendance> GetAttendanceList()
        {
            try
            {
                List<Attendance> attendanceList = new List<Attendance>();
                con.Open();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM attendance;", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Attendance a = new Attendance(rd.GetValue(0).ToString(), rd.GetValue(1).ToString(), DateTime.Parse(rd.GetValue(2).ToString()), rd.GetValue(3).ToString());
                    attendanceList.Add(a);
                }
                rd.Close();
                con.Close();
                return attendanceList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        public Product GetProductByModel(string model)
        {
            try
            {
                con.Open();
                this.CheckConnection();
                MySqlDataReader rd;
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM product WHERE Model='"+model+"';", con);
                rd = cmd.ExecuteReader();

                    Enum.TryParse(rd.GetValue(6).ToString(), out Department category);

                    Product p = new Product(rd.GetValue(0).ToString(), rd.GetValue(1).ToString(), Convert.ToDouble(rd.GetValue(2)), Convert.ToDouble(rd.GetValue(3)), Convert.ToDouble(rd.GetValue(4)), rd.GetValue(5).ToString(), category, Convert.ToDouble(rd.GetValue(7)), Convert.ToInt32(rd.GetValue(8)), Convert.ToInt32(rd.GetValue(9)), Convert.ToInt32(rd.GetValue(10)), rd.GetValue(11).ToString(), Convert.ToInt32(rd.GetValue(12)), DateTime.Parse(rd.GetValue(13).ToString()), rd.GetValue(14).ToString());
                    
                rd.Close();
                con.Close();
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
