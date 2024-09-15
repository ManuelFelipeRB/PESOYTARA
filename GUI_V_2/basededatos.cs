using System;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Linq;


public partial class basededatos
{
    public string fecha;
    public string hora;
    public string placa;
    private string ejes;
    private string tara;
    private string pesoini;
    private string pesofin;
    private string peso_neto;


    SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-9HUMB1K\SQLEXPRESS;Initial Catalog=Pesos;Integrated Security=True;TrustServerCertificate=True");

    public basededatos(string fecha, string hora, string placa, string ejes, string pesoini, string pesofin, string tara, string peso_neto)
    {
        this.fecha = fecha;
        this.hora = hora;
        this.placa = placa;
        this.ejes = ejes;
        this.pesoini = pesoini;
        this.pesofin = pesofin;
        this.tara = tara;
        this.peso_neto = peso_neto;


    }
    public basededatos()
    { }

    public int addeventopesaje()
    {
        cnx.Open();
        SqlCommand consulta = new SqlCommand("INSERT INTO Eventos_Pesajes VALUES (@fecha,@hora, @placa, @ejes, @peso_ini, @peso_fin, @tara, @neto)", cnx);

        consulta.Parameters.AddWithValue("@fecha", fecha);
        consulta.Parameters.AddWithValue("@hora", hora);
        consulta.Parameters.AddWithValue("@placa", placa);
        consulta.Parameters.AddWithValue("@ejes", ejes);
        consulta.Parameters.AddWithValue("@peso_ini", pesoini);
        consulta.Parameters.AddWithValue("@peso_fin", pesofin);
        consulta.Parameters.AddWithValue("@tara", tara);
        consulta.Parameters.AddWithValue("@neto", peso_neto);

        // Asigna los valores de los demás parámetros aquí

        int filasagregadas = consulta.ExecuteNonQuery();
        cnx.Close();
        return filasagregadas;
    }
    public void EventosdePesaje(DataGridView dgv_eventos)
    {
        string consulta = "SELECT * FROM Eventos_Pesajes ORDER BY Num DESC";
        
        cnx.Open();
        SqlDataAdapter datos = new SqlDataAdapter(consulta, cnx);
        DataTable dttabla = new DataTable();
        datos.Fill(dttabla);
        dgv_eventos.DataSource = dttabla;
        
        cnx.Close();

    }



}

