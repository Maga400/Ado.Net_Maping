
using Ado.Net_Practics;
using Microsoft.Data.SqlClient;

string connectionStr = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Vehicle;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
SqlConnection sqlConnection = new SqlConnection(connectionStr);

List<Car> cars = new List<Car>();
List<Airplane> airplanes = new List<Airplane>();
List<Motorcycle> motorcycles = new List<Motorcycle>();


//MapingForCars();
//ReadCarsList();

//MapingForAirplanes();
//ReadAirplanesList();

MapingForMotorcycles();
ReadMotorcyclesList();

void MapingForCars()
{
    try
    {
        sqlConnection.Open();

        string query = "SELECT * FROM Cars";
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        SqlDataReader reader = sqlCommand.ExecuteReader();


        while (reader.Read())
        {
            Car car = new Car();
            car.Id = Convert.ToInt32(reader[0]);
            car.Marka = reader[1].ToString();
            car.Model = reader[2].ToString();
            car.Price = Convert.ToDouble(reader[3]);

            cars.Add(car);

        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        sqlConnection.Close();
    }


}
void ReadCarsList()
{
    foreach (var car in cars)
    {
        Console.WriteLine(car.ToString());
    }
}

void MapingForAirplanes() 
{
    try 
    {
        sqlConnection.Open();
        string query = "SELECT * FROM Airplanes";
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        SqlDataReader reader = sqlCommand.ExecuteReader();

        while(reader.Read()) 
        {
            Airplane airplane = new Airplane();

            airplane.Id = Convert.ToInt32(reader[0]);
            airplane.Marka = reader[1].ToString();
            airplane.Model = reader[2].ToString();
            airplane.Price = Convert.ToDouble(reader[3]);

            airplanes.Add(airplane);

        }
    }
    catch(Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
    finally
    { 
        sqlConnection.Close(); 
    }
}

void ReadAirplanesList() 
{
    foreach(var airplane in airplanes) 
    {
        Console.WriteLine(airplane.ToString());
    }
}

void MapingForMotorcycles()
{
    try
    {
        sqlConnection.Open();

        string query = "SELECT * FROM Motorcycles";
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        SqlDataReader reader = sqlCommand.ExecuteReader();


        while (reader.Read())
        {
            Motorcycle mc = new Motorcycle();
            mc.Id = Convert.ToInt32(reader[0]);
            mc.Marka = reader[1].ToString();
            mc.Model = reader[2].ToString();
            mc.Price = Convert.ToDouble(reader[3]);

            motorcycles.Add(mc);

        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        sqlConnection.Close();
    }


}
void ReadMotorcyclesList()
{
    foreach (var motorcycle in motorcycles)
    {
        Console.WriteLine(motorcycle.ToString());
    }
}




