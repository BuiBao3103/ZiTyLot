using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.ResidentScr
{   
    public partial class ResidentDetailForm : Form
    {
        private readonly ResidentBUS residentBUS = new ResidentBUS();
        public readonly Resident resident;

        private readonly IssueBUS issueBUS = new IssueBUS();

        private readonly BillBUS billBus = new BillBUS();

        public event EventHandler ResidentUpdateEvent;
        private  readonly List<Bill> bills;
        private readonly List<Issue> issues;
       
        public ResidentDetailForm(int residentId)
        {
            InitializeComponent();
            this.CenterToScreen();
            
            resident = residentBUS.GetById(residentId);
            tbFullname.Text = resident.Full_name;
            uiTextBox1.Text = resident.Apartment_id;
            uiTextBox2.Text = resident.Email;
            uiTextBox3.Text = resident.Phone;

            bills = new List<Bill>(residentBUS.PopulateBills(resident).Bills);
            foreach (Bill bill in bills)
            {
                issues = new List<Issue>(billBus.PopulateIssues(bill).Issues);
                if (bill.Issue_quantity == 1)
                {
                    tableAccount.Rows.Add(issues[0].Id, issues[0].License_plate
                        , issueBUS.PopulateVehicleType(issues[0]).Vehicle_type.Name
                        , issues[0].Start_date, issues[0].End_date);

                }
                else
                {
                    foreach (Issue issue in issues)
                    {
                        tableAccount.Rows.Add(issue.Id, issue.License_plate
                        , issueBUS.PopulateVehicleType(issue).Vehicle_type.Name
                        , issue.Start_date, issues[0].End_date);
                    }
                }
            }

        }

       
    }
}
