using System;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Windows.Forms;

namespace LDAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool _store=false;
        public LdapConnection ldapConnection;
        public string _server;
        public string _dn;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _server = server.Text;
            int _port = Int32.Parse(port.Text);
            _dn = DN.Text;
            string _pass = pass.Text;
            if (_store == false)
            {
                if (ConnectToLDAP(_server, _port, _dn, _pass) == true)
                {
                    connectbtn.Text = "CONNECTED";
                    connectbtn.BackColor = System.Drawing.Color.LightGreen;
                }
                
            }
            else
            {
                ldapConnection.Dispose();
                connectbtn.Text = "DISCONNECTED";
                connectbtn.BackColor = System.Drawing.Color.Red;
            }
        }
        public bool ConnectToLDAP(String _s, int _Po, String _Dn, String _Pa )
        {
            try
            {
                // Create the new LDAP connection
                LdapDirectoryIdentifier ldi = new LdapDirectoryIdentifier(_s, _Po);
                ldapConnection =
                    new System.DirectoryServices.Protocols.LdapConnection(ldi);
                Console.WriteLine("LdapConnection is created successfully.");
                ldapConnection.AuthType = AuthType.Basic;
                ldapConnection.SessionOptions.ProtocolVersion = 3;
                NetworkCredential nc = new System.Net.NetworkCredential(_Dn,
                    _Pa); //password
                ldapConnection.Bind(nc);
                _store = true;
                return true;
            }
            catch (Exception ex) { 
                return false; 
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string searchString=searchfield.Text;
            DirectoryEntry rootEntry = new DirectoryEntry("LDAP://ldap.forumsys.com", "read-only-admin", "password")
            {
                AuthenticationType = AuthenticationTypes.None //Or whatever it need be
            };
            DirectorySearcher searcher = new DirectorySearcher(rootEntry);
            var queryFormat = "(&(objectClass=user)(|(cn=*{0}*)(sn=*{0}*)(email=*{0}*)))";
            searcher.Filter = string.Format(queryFormat, searchString);
            SearchResultCollection resultCollection = searcher.FindAll();
            foreach (SearchResult result in resultCollection)
            {
                Console.WriteLine("account name: {0}", result.Properties["samaccountname"].Count > 0 ? result.Properties["samaccountname"][0] : string.Empty);
                Console.WriteLine("common name: {0}", result.Properties["cn"].Count > 0 ? result.Properties["cn"][0] : string.Empty);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
