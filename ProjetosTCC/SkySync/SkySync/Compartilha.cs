using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkySync
{
    internal class Compartilha
    {
        static String email = "";
        static String emailConsulta = "";
        static String idConsulta = "";

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String v)
        {
            email = v;
        }

        public String getemailConsulta()
        {
            return emailConsulta;
        }

        public void setemailConsulta(String v)
        {
            emailConsulta = v;
        }

        public String getidConsulta()
        {
            return idConsulta;
        }

        public void setidConsulta(String v)
        {
            idConsulta = v;
        }
    }
}
