using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.RoleScr
{
    public partial class RoleDetailForm : Form
    {
        private readonly RoleBUS roleBUS = new RoleBUS();
        public readonly Role role;

        private readonly FunctionBUS functionBUS = new FunctionBUS();
        private readonly List<Function> functions = new List<Function>();
        private readonly List<Function> functionsDo;

        public event EventHandler RoleUpdateEvent;
        public RoleDetailForm(int roleId)
        {
            InitializeComponent();
            this.CenterToScreen();

            role = roleBUS.GetById(roleId);
            tbName.Text = role.Name;

            functions = functionBUS.GetAll();
            listFunction.DataSource = functions;
            listFunction.DisplayMember = nameof(Function.Name);

            functionsDo = new List<Function>(roleBUS.PopulateFunctions(role).Functions);
            listDo.DataSource = functionsDo;
            listDo.DisplayMember = nameof(Function.Name);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
