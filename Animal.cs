using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace singgle.Classes
{
    class Animal
    {
        private String nomeAnimal;

        public String NomeAnimal
        {
            get { return nomeAnimal; }
            set { nomeAnimal = value; }
        }

        private int brincoAnimal;

        public int BrincoAnimal
        {
            get { return brincoAnimal; }
            set { brincoAnimal = value; }
        }

        private String dt_nascAnimal;

        public String Dt_nascAnimal
        {
            get { return dt_nascAnimal; }
            set { dt_nascAnimal = value; }
        }

        private String paiAnimal;

        public String PaiAnimal
        {
            get { return paiAnimal; }
            set { paiAnimal = value; }
        }

        private String maeAnimal;

        public String MaeAnimal
        {
            get { return maeAnimal; }
            set { maeAnimal = value; }
        }

        private char sexoAnimal;

        public char SexoAnimal
        {
            get { return sexoAnimal; }
            set { sexoAnimal = value; }
        }

        private String dt_baixaAnimal;

        public String Dt_baixaAnimal
        {
            get { return dt_baixaAnimal; }
            set { dt_baixaAnimal = value; }
        }

        private String mot_baixaAnimal;

        public String Mot_baixaAnimal
        {
            get { return mot_baixaAnimal; }
            set { mot_baixaAnimal = value; }
        }

        private String mot_obitoAnimal;

        public String Mot_obitoAnimal
        {
            get { return mot_obitoAnimal; }
            set { mot_obitoAnimal = value; }
        }

        private String dt_1repAnimal;

        public String Dt_1repAnimal
        {
            get { return dt_1repAnimal; }
            set { dt_1repAnimal = value; }
        }

        private float pesoAnimal;

        public float PesoAnimal
        {
            get { return pesoAnimal; }
            set { pesoAnimal = value; }
        }

        private int idRaca;

        public int IdRaca
        {
            get { return idRaca; }
            set { idRaca = value; }
        }

        private int idPropriedade;

        public int IdPropriedade
        {
            get { return idPropriedade; }
            set { idPropriedade = value; }
        }

        public void cadastrarAnimal()
        {
            MySqlConnection Conn = new MySqlConnection("server=69.64.33.121;user id=mnettec1_sing;password=poucasombra10;persistsecurityinfo=True;database=mnettec1_singgle");
            Conn.Open();

            String sql = "INSERT INTO animal(nomeAnimal, brincoAnimal, dt_nascAnimal, paiAnimal, maeAnimal, sexoAnimal,"+
                "dt_baixaAnimal, mot_baixaAnimal, mot_obitoAnimal, dt_1repAnimal, pesoAnimal, idRaca, idPropriedade) VALUES"+
                "("+nomeAnimal+","+brincoAnimal+","+dt_nascAnimal+","+paiAnimal+","+maeAnimal+","+sexoAnimal+","+dt_baixaAnimal+""+
                ""+mot_baixaAnimal+","+mot_obitoAnimal+","+dt_1repAnimal+","+pesoAnimal+","+idRaca+","+idPropriedade+")";

            MySqlCommand cmd = new MySqlCommand(sql, Conn);
            cmd.ExecuteNonQuery();

            Conn.Close();

            MessageBox.Show("Gravado com Sucesso!");
        }
    }
}
