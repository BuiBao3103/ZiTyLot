﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.RoleScr
{
    public partial class RoleCreateForm : Form
    {
        private readonly FunctionBUS functionBUS = new FunctionBUS();
        private readonly RoleBUS roleBUS = new RoleBUS();
        private readonly RoleFunctionBUS roleFunctionBUS = new RoleFunctionBUS();
        private readonly List<Function> functions = new List<Function>();
        private readonly List<Function> functionsDo = new List<Function>();

        public event EventHandler RoleCreated;

        public RoleCreateForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            functions = functionBUS.GetAll();
            listFunction.DataSource = functions;
            listFunction.DisplayMember = nameof(Function.Name);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                Role role = new Role
                {
                    Name = tbName.Text.Trim()
                };
                List<RoleFunction> roleFunctions = 
                    functionsDo.Select(function => new RoleFunction { Function_id = function.Id }).ToList();
                roleBUS.Create(role, roleFunctions);
                MessageHelper.ShowSuccess("Role added successfully!");
                RoleCreated?.Invoke(this, EventArgs.Empty);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listFunction.SelectedItem != null)
            {
                functionsDo.Add((Function) listFunction.SelectedItem);
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
