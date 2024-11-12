using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.RoleScr
{
    public partial class RoleDetailForm : Form
    {
        private readonly RoleBUS roleBUS = new RoleBUS();
        public readonly Role role;

        private readonly RoleFunctionBUS roleFunctionBUS = new RoleFunctionBUS();
        private readonly FunctionBUS functionBUS = new FunctionBUS();
        private readonly List<Function> functions = new List<Function>();
        private readonly List<Function> functionsDo = new List<Function>();

        public event EventHandler RoleUpdateEvent;
        public RoleDetailForm(int roleId)
        {
            InitializeComponent();
            this.CenterToScreen();

            role = roleBUS.GetById(roleId);
            tbName.Text = role.Name;

            functionsDo = (List<Function>) roleBUS.PopulateFunctions(role).Functions;
            listDo.DataSource = functionsDo;
            listDo.DisplayMember = nameof(Function.Name);

            functions = functionBUS.GetAll();
            functions.RemoveAll(f => functionsDo.Any(fd => fd.Id == f.Id));
            listFunction.DataSource = functions;
            listFunction.DisplayMember = nameof(Function.Name);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listFunction.SelectedItem != null)
            {
                functionsDo.Add((Function)listFunction.SelectedItem);
                functions.Remove((Function)listFunction.SelectedItem);
                updateListBox();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listDo.SelectedItem != null)
            {
                functionsDo.Remove((Function)listDo.SelectedItem);
                functions.Add((Function)listDo.SelectedItem);
                updateListBox();
            }
        }

        private void updateListBox()
        {
            listFunction.DataSource = null;
            listFunction.DataSource = functions;
            listFunction.DisplayMember = nameof(Function.Name);
            listDo.DataSource = null;
            listDo.DataSource = functionsDo;
            listDo.DisplayMember = nameof(Function.Name);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                role.Name = tbName.Text.Trim();
                role.Updated_at = DateTime.Now;
                roleBUS.Update(role);
                // Delete all roleFunctions in this role
                roleFunctionBUS.Delete(role.Id);
                // Add new roleFuntions
                List<RoleFunction> roleFunctions = functionsDo.Select(f => new RoleFunction {Role_id = role.Id, Function_id = f.Id}).ToList();
                foreach (RoleFunction roleFunction in roleFunctions)
                {
                    roleFunctionBUS.Add(roleFunction);
                }
                MessageHelper.ShowSuccess("Role updated successfully!");
                RoleUpdateEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred. Please try again later.");
                MessageHelper.ShowError("An unexpected error occurred. Please try again later.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageHelper.ShowWarning("Please enter role name");
                tbName.Focus();
                return false;
            }

            if (listDo.Items.Count == 0)
            {
                MessageHelper.ShowWarning("Please add at least 1 function");
                return false;
            }
            return true;
        }
    }
}
