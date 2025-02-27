﻿namespace WPELibrary
{
    partial class Socket_RobotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Socket_RobotForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpRobotForm = new System.Windows.Forms.TableLayoutPanel();
            this.ssRobotInstruction = new System.Windows.Forms.StatusStrip();
            this.ssRobotInstruction_Total = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRobotInstruction_Total_Value = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRobotInstruction_Split1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRobotInstruction_Success = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRobotInstruction_Success_Value = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRobotInstruction_Fail = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssRobotInstruction_Fail_Value = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpListInfo = new System.Windows.Forms.TableLayoutPanel();
            this.gbSendList = new System.Windows.Forms.GroupBox();
            this.dgvSendList = new System.Windows.Forms.DataGridView();
            this.cSendList_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIPTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpRobotInfo = new System.Windows.Forms.TableLayoutPanel();
            this.gbRobotName = new System.Windows.Forms.GroupBox();
            this.txtRobotName = new System.Windows.Forms.TextBox();
            this.gbRobotInstruction = new System.Windows.Forms.GroupBox();
            this.dgvRobotInstruction = new System.Windows.Forms.DataGridView();
            this.cRobotInstruction_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRobotInstruction_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRobotInstruction_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsRobotInstruction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsRobotInstruction_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsRobotInstruction_Up = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRobotInstruction_Down = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsRobotInstruction_Bottom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsRobotInstruction_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRobotInstruction_CleanUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tcRobotInstruction = new System.Windows.Forms.TabControl();
            this.tpInstruction_Socket = new System.Windows.Forms.TabPage();
            this.tlpInstruction_Socket = new System.Windows.Forms.TableLayoutPanel();
            this.gbSpecifySend = new System.Windows.Forms.GroupBox();
            this.tlpSpecifySend = new System.Windows.Forms.TableLayoutPanel();
            this.bSend_SocketList = new System.Windows.Forms.Button();
            this.lSpecifySend_SocketList = new System.Windows.Forms.Label();
            this.gbSend = new System.Windows.Forms.GroupBox();
            this.tlpSend = new System.Windows.Forms.TableLayoutPanel();
            this.nudSendSocket = new System.Windows.Forms.NumericUpDown();
            this.lSendSocket = new System.Windows.Forms.Label();
            this.nudSendInterval = new System.Windows.Forms.NumericUpDown();
            this.lSendInterval = new System.Windows.Forms.Label();
            this.nudSendTimes = new System.Windows.Forms.NumericUpDown();
            this.lSendTimes = new System.Windows.Forms.Label();
            this.lSendIndex = new System.Windows.Forms.Label();
            this.nudSendIndex = new System.Windows.Forms.NumericUpDown();
            this.bSend = new System.Windows.Forms.Button();
            this.tpInstruction_Control = new System.Windows.Forms.TabPage();
            this.tlpInstruction_Control = new System.Windows.Forms.TableLayoutPanel();
            this.gbLoop = new System.Windows.Forms.GroupBox();
            this.tlpLoop = new System.Windows.Forms.TableLayoutPanel();
            this.lLoop = new System.Windows.Forms.Label();
            this.bLoopEnd = new System.Windows.Forms.Button();
            this.bLoopStart = new System.Windows.Forms.Button();
            this.nudLoop = new System.Windows.Forms.NumericUpDown();
            this.gbDelay = new System.Windows.Forms.GroupBox();
            this.tlpDelay = new System.Windows.Forms.TableLayoutPanel();
            this.lDelay = new System.Windows.Forms.Label();
            this.bDelay = new System.Windows.Forms.Button();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.tpInstruction_keyboard = new System.Windows.Forms.TabPage();
            this.tlpInstruction_keyboard = new System.Windows.Forms.TableLayoutPanel();
            this.gbKeyboard = new System.Windows.Forms.GroupBox();
            this.tlpKeyboard = new System.Windows.Forms.TableLayoutPanel();
            this.cbbKeyBoard_KeyType = new System.Windows.Forms.ComboBox();
            this.lKeyBoard_KeyType = new System.Windows.Forms.Label();
            this.nudKeyBoard_Interval = new System.Windows.Forms.NumericUpDown();
            this.lKeyBoard_Interval = new System.Windows.Forms.Label();
            this.lKeyBoard_Times = new System.Windows.Forms.Label();
            this.lKeyBoard_KeyCode = new System.Windows.Forms.Label();
            this.txtKeyBoard_KeyCode = new System.Windows.Forms.TextBox();
            this.nudKeyBoard_Times = new System.Windows.Forms.NumericUpDown();
            this.bKeyBoard = new System.Windows.Forms.Button();
            this.tlpKeyBoardCombine = new System.Windows.Forms.TableLayoutPanel();
            this.gbKeyboard_Text = new System.Windows.Forms.GroupBox();
            this.tlpKeyboard_Text = new System.Windows.Forms.TableLayoutPanel();
            this.txtKeyboard_Text = new System.Windows.Forms.TextBox();
            this.bKeyboard_Text = new System.Windows.Forms.Button();
            this.gbKeyboard_combination = new System.Windows.Forms.GroupBox();
            this.tlpKeyboard_combination = new System.Windows.Forms.TableLayoutPanel();
            this.lKeyboard_combination = new System.Windows.Forms.Label();
            this.txtKeyboard_combination = new System.Windows.Forms.TextBox();
            this.bKeyboard_combination = new System.Windows.Forms.Button();
            this.tpInstruction_Mouse = new System.Windows.Forms.TabPage();
            this.tlpInstruction_Mouse = new System.Windows.Forms.TableLayoutPanel();
            this.gbMouseWheel = new System.Windows.Forms.GroupBox();
            this.tlpMouseWheel = new System.Windows.Forms.TableLayoutPanel();
            this.lMouseWheel_Distance = new System.Windows.Forms.Label();
            this.lMouseWheel_Direction = new System.Windows.Forms.Label();
            this.nudMouseWheel_Distance = new System.Windows.Forms.NumericUpDown();
            this.bMouseWheel = new System.Windows.Forms.Button();
            this.cbbMouseWheel_Direction = new System.Windows.Forms.ComboBox();
            this.gbMouseMove = new System.Windows.Forms.GroupBox();
            this.tlpMouseMove = new System.Windows.Forms.TableLayoutPanel();
            this.rbMoveBy = new System.Windows.Forms.RadioButton();
            this.nudMouseMove_Y = new System.Windows.Forms.NumericUpDown();
            this.lMouseMove_Y = new System.Windows.Forms.Label();
            this.bMouseMove = new System.Windows.Forms.Button();
            this.nudMouseMove_X = new System.Windows.Forms.NumericUpDown();
            this.lMouseMove_X = new System.Windows.Forms.Label();
            this.rbMoveTo = new System.Windows.Forms.RadioButton();
            this.gbMouse = new System.Windows.Forms.GroupBox();
            this.tlpMouse = new System.Windows.Forms.TableLayoutPanel();
            this.nudMouse_Interval = new System.Windows.Forms.NumericUpDown();
            this.lMouse_Interval = new System.Windows.Forms.Label();
            this.lMouse_Times = new System.Windows.Forms.Label();
            this.lMouse = new System.Windows.Forms.Label();
            this.nudMouse_Times = new System.Windows.Forms.NumericUpDown();
            this.bMouse = new System.Windows.Forms.Button();
            this.cbbMouse = new System.Windows.Forms.ComboBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.bStop = new System.Windows.Forms.Button();
            this.bExecute = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.gbExecute = new System.Windows.Forms.GroupBox();
            this.txtExecute = new System.Windows.Forms.TextBox();
            this.tlpRobotForm.SuspendLayout();
            this.ssRobotInstruction.SuspendLayout();
            this.tlpListInfo.SuspendLayout();
            this.gbSendList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).BeginInit();
            this.tlpRobotInfo.SuspendLayout();
            this.gbRobotName.SuspendLayout();
            this.gbRobotInstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobotInstruction)).BeginInit();
            this.cmsRobotInstruction.SuspendLayout();
            this.tcRobotInstruction.SuspendLayout();
            this.tpInstruction_Socket.SuspendLayout();
            this.tlpInstruction_Socket.SuspendLayout();
            this.gbSpecifySend.SuspendLayout();
            this.tlpSpecifySend.SuspendLayout();
            this.gbSend.SuspendLayout();
            this.tlpSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendSocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendIndex)).BeginInit();
            this.tpInstruction_Control.SuspendLayout();
            this.tlpInstruction_Control.SuspendLayout();
            this.gbLoop.SuspendLayout();
            this.tlpLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoop)).BeginInit();
            this.gbDelay.SuspendLayout();
            this.tlpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.tpInstruction_keyboard.SuspendLayout();
            this.tlpInstruction_keyboard.SuspendLayout();
            this.gbKeyboard.SuspendLayout();
            this.tlpKeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeyBoard_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeyBoard_Times)).BeginInit();
            this.tlpKeyBoardCombine.SuspendLayout();
            this.gbKeyboard_Text.SuspendLayout();
            this.tlpKeyboard_Text.SuspendLayout();
            this.gbKeyboard_combination.SuspendLayout();
            this.tlpKeyboard_combination.SuspendLayout();
            this.tpInstruction_Mouse.SuspendLayout();
            this.tlpInstruction_Mouse.SuspendLayout();
            this.gbMouseWheel.SuspendLayout();
            this.tlpMouseWheel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseWheel_Distance)).BeginInit();
            this.gbMouseMove.SuspendLayout();
            this.tlpMouseMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseMove_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseMove_X)).BeginInit();
            this.gbMouse.SuspendLayout();
            this.tlpMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouse_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouse_Times)).BeginInit();
            this.tlpButton.SuspendLayout();
            this.gbExecute.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRobotForm
            // 
            resources.ApplyResources(this.tlpRobotForm, "tlpRobotForm");
            this.tlpRobotForm.Controls.Add(this.ssRobotInstruction, 0, 4);
            this.tlpRobotForm.Controls.Add(this.tlpListInfo, 0, 0);
            this.tlpRobotForm.Controls.Add(this.tcRobotInstruction, 0, 2);
            this.tlpRobotForm.Controls.Add(this.tlpButton, 0, 3);
            this.tlpRobotForm.Controls.Add(this.gbExecute, 0, 1);
            this.tlpRobotForm.Name = "tlpRobotForm";
            // 
            // ssRobotInstruction
            // 
            resources.ApplyResources(this.ssRobotInstruction, "ssRobotInstruction");
            this.ssRobotInstruction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssRobotInstruction_Total,
            this.ssRobotInstruction_Total_Value,
            this.ssRobotInstruction_Split1,
            this.ssRobotInstruction_Success,
            this.ssRobotInstruction_Success_Value,
            this.toolStripStatusLabel3,
            this.ssRobotInstruction_Fail,
            this.ssRobotInstruction_Fail_Value});
            this.ssRobotInstruction.Name = "ssRobotInstruction";
            // 
            // ssRobotInstruction_Total
            // 
            resources.ApplyResources(this.ssRobotInstruction_Total, "ssRobotInstruction_Total");
            this.ssRobotInstruction_Total.Name = "ssRobotInstruction_Total";
            // 
            // ssRobotInstruction_Total_Value
            // 
            resources.ApplyResources(this.ssRobotInstruction_Total_Value, "ssRobotInstruction_Total_Value");
            this.ssRobotInstruction_Total_Value.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ssRobotInstruction_Total_Value.Name = "ssRobotInstruction_Total_Value";
            // 
            // ssRobotInstruction_Split1
            // 
            resources.ApplyResources(this.ssRobotInstruction_Split1, "ssRobotInstruction_Split1");
            this.ssRobotInstruction_Split1.ForeColor = System.Drawing.Color.DarkGray;
            this.ssRobotInstruction_Split1.Name = "ssRobotInstruction_Split1";
            // 
            // ssRobotInstruction_Success
            // 
            resources.ApplyResources(this.ssRobotInstruction_Success, "ssRobotInstruction_Success");
            this.ssRobotInstruction_Success.Name = "ssRobotInstruction_Success";
            // 
            // ssRobotInstruction_Success_Value
            // 
            resources.ApplyResources(this.ssRobotInstruction_Success_Value, "ssRobotInstruction_Success_Value");
            this.ssRobotInstruction_Success_Value.ForeColor = System.Drawing.Color.DarkGreen;
            this.ssRobotInstruction_Success_Value.Name = "ssRobotInstruction_Success_Value";
            // 
            // toolStripStatusLabel3
            // 
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            // 
            // ssRobotInstruction_Fail
            // 
            resources.ApplyResources(this.ssRobotInstruction_Fail, "ssRobotInstruction_Fail");
            this.ssRobotInstruction_Fail.Name = "ssRobotInstruction_Fail";
            // 
            // ssRobotInstruction_Fail_Value
            // 
            resources.ApplyResources(this.ssRobotInstruction_Fail_Value, "ssRobotInstruction_Fail_Value");
            this.ssRobotInstruction_Fail_Value.ForeColor = System.Drawing.Color.DarkRed;
            this.ssRobotInstruction_Fail_Value.Name = "ssRobotInstruction_Fail_Value";
            // 
            // tlpListInfo
            // 
            resources.ApplyResources(this.tlpListInfo, "tlpListInfo");
            this.tlpListInfo.Controls.Add(this.gbSendList, 1, 0);
            this.tlpListInfo.Controls.Add(this.tlpRobotInfo, 0, 0);
            this.tlpListInfo.Name = "tlpListInfo";
            // 
            // gbSendList
            // 
            resources.ApplyResources(this.gbSendList, "gbSendList");
            this.gbSendList.Controls.Add(this.dgvSendList);
            this.gbSendList.Name = "gbSendList";
            this.gbSendList.TabStop = false;
            // 
            // dgvSendList
            // 
            resources.ApplyResources(this.dgvSendList, "dgvSendList");
            this.dgvSendList.AllowUserToAddRows = false;
            this.dgvSendList.AllowUserToDeleteRows = false;
            this.dgvSendList.AllowUserToResizeRows = false;
            this.dgvSendList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvSendList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSendList_ID,
            this.cNote,
            this.cSocket,
            this.cType,
            this.cIPTo,
            this.cLen});
            this.dgvSendList.MultiSelect = false;
            this.dgvSendList.Name = "dgvSendList";
            this.dgvSendList.RowHeadersVisible = false;
            this.dgvSendList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvSendList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSendList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.LimeGreen;
            this.dgvSendList.RowTemplate.Height = 23;
            this.dgvSendList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSendList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSendList_CellFormatting);
            this.dgvSendList.SelectionChanged += new System.EventHandler(this.dgvSendList_SelectionChanged);
            // 
            // cSendList_ID
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSendList_ID.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.cSendList_ID, "cSendList_ID");
            this.cSendList_ID.Name = "cSendList_ID";
            this.cSendList_ID.ReadOnly = true;
            this.cSendList_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSendList_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cNote
            // 
            this.cNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNote.DataPropertyName = "Remark";
            resources.ApplyResources(this.cNote, "cNote");
            this.cNote.Name = "cNote";
            this.cNote.ReadOnly = true;
            this.cNote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cSocket
            // 
            this.cSocket.DataPropertyName = "Socket";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cSocket.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.cSocket, "cSocket");
            this.cSocket.Name = "cSocket";
            this.cSocket.ReadOnly = true;
            this.cSocket.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSocket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cType
            // 
            this.cType.DataPropertyName = "Type";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cType.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.cType, "cType");
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            this.cType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIPTo
            // 
            this.cIPTo.DataPropertyName = "ToAddress";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cIPTo.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.cIPTo, "cIPTo");
            this.cIPTo.Name = "cIPTo";
            this.cIPTo.ReadOnly = true;
            this.cIPTo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIPTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cLen
            // 
            this.cLen.DataPropertyName = "Len";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cLen.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.cLen, "cLen");
            this.cLen.Name = "cLen";
            this.cLen.ReadOnly = true;
            this.cLen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cLen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpRobotInfo
            // 
            resources.ApplyResources(this.tlpRobotInfo, "tlpRobotInfo");
            this.tlpRobotInfo.Controls.Add(this.gbRobotName, 0, 0);
            this.tlpRobotInfo.Controls.Add(this.gbRobotInstruction, 0, 1);
            this.tlpRobotInfo.Name = "tlpRobotInfo";
            // 
            // gbRobotName
            // 
            resources.ApplyResources(this.gbRobotName, "gbRobotName");
            this.gbRobotName.Controls.Add(this.txtRobotName);
            this.gbRobotName.Name = "gbRobotName";
            this.gbRobotName.TabStop = false;
            // 
            // txtRobotName
            // 
            resources.ApplyResources(this.txtRobotName, "txtRobotName");
            this.txtRobotName.Name = "txtRobotName";
            // 
            // gbRobotInstruction
            // 
            resources.ApplyResources(this.gbRobotInstruction, "gbRobotInstruction");
            this.gbRobotInstruction.Controls.Add(this.dgvRobotInstruction);
            this.gbRobotInstruction.Name = "gbRobotInstruction";
            this.gbRobotInstruction.TabStop = false;
            // 
            // dgvRobotInstruction
            // 
            resources.ApplyResources(this.dgvRobotInstruction, "dgvRobotInstruction");
            this.dgvRobotInstruction.AllowUserToAddRows = false;
            this.dgvRobotInstruction.AllowUserToDeleteRows = false;
            this.dgvRobotInstruction.AllowUserToResizeRows = false;
            this.dgvRobotInstruction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvRobotInstruction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRobotInstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRobotInstruction.ColumnHeadersVisible = false;
            this.dgvRobotInstruction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRobotInstruction_ID,
            this.cRobotInstruction_Type,
            this.cRobotInstruction_Content});
            this.dgvRobotInstruction.ContextMenuStrip = this.cmsRobotInstruction;
            this.dgvRobotInstruction.MultiSelect = false;
            this.dgvRobotInstruction.Name = "dgvRobotInstruction";
            this.dgvRobotInstruction.ReadOnly = true;
            this.dgvRobotInstruction.RowHeadersVisible = false;
            this.dgvRobotInstruction.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvRobotInstruction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvRobotInstruction.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Window;
            this.dgvRobotInstruction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            this.dgvRobotInstruction.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRobotInstruction.RowTemplate.Height = 23;
            this.dgvRobotInstruction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRobotInstruction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRobotInstruction_CellFormatting);
            // 
            // cRobotInstruction_ID
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cRobotInstruction_ID.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.cRobotInstruction_ID, "cRobotInstruction_ID");
            this.cRobotInstruction_ID.Name = "cRobotInstruction_ID";
            this.cRobotInstruction_ID.ReadOnly = true;
            this.cRobotInstruction_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRobotInstruction_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRobotInstruction_Type
            // 
            this.cRobotInstruction_Type.DataPropertyName = "Type";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cRobotInstruction_Type.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.cRobotInstruction_Type, "cRobotInstruction_Type");
            this.cRobotInstruction_Type.Name = "cRobotInstruction_Type";
            this.cRobotInstruction_Type.ReadOnly = true;
            this.cRobotInstruction_Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRobotInstruction_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cRobotInstruction_Content
            // 
            this.cRobotInstruction_Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cRobotInstruction_Content.DataPropertyName = "Content";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cRobotInstruction_Content.DefaultCellStyle = dataGridViewCellStyle16;
            resources.ApplyResources(this.cRobotInstruction_Content, "cRobotInstruction_Content");
            this.cRobotInstruction_Content.Name = "cRobotInstruction_Content";
            this.cRobotInstruction_Content.ReadOnly = true;
            this.cRobotInstruction_Content.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRobotInstruction_Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsRobotInstruction
            // 
            resources.ApplyResources(this.cmsRobotInstruction, "cmsRobotInstruction");
            this.cmsRobotInstruction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsRobotInstruction_Top,
            this.toolStripSeparator1,
            this.cmsRobotInstruction_Up,
            this.cmsRobotInstruction_Down,
            this.toolStripSeparator2,
            this.cmsRobotInstruction_Bottom,
            this.toolStripSeparator3,
            this.cmsRobotInstruction_Delete,
            this.cmsRobotInstruction_CleanUp});
            this.cmsRobotInstruction.Name = "cmsRobotInstruction";
            this.cmsRobotInstruction.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsRobotInstruction_ItemClicked);
            // 
            // cmsRobotInstruction_Top
            // 
            resources.ApplyResources(this.cmsRobotInstruction_Top, "cmsRobotInstruction_Top");
            this.cmsRobotInstruction_Top.Image = global::WPELibrary.Properties.Resources.go_top;
            this.cmsRobotInstruction_Top.Name = "cmsRobotInstruction_Top";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // cmsRobotInstruction_Up
            // 
            resources.ApplyResources(this.cmsRobotInstruction_Up, "cmsRobotInstruction_Up");
            this.cmsRobotInstruction_Up.Image = global::WPELibrary.Properties.Resources.Up;
            this.cmsRobotInstruction_Up.Name = "cmsRobotInstruction_Up";
            // 
            // cmsRobotInstruction_Down
            // 
            resources.ApplyResources(this.cmsRobotInstruction_Down, "cmsRobotInstruction_Down");
            this.cmsRobotInstruction_Down.Image = global::WPELibrary.Properties.Resources.Down;
            this.cmsRobotInstruction_Down.Name = "cmsRobotInstruction_Down";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // cmsRobotInstruction_Bottom
            // 
            resources.ApplyResources(this.cmsRobotInstruction_Bottom, "cmsRobotInstruction_Bottom");
            this.cmsRobotInstruction_Bottom.Image = global::WPELibrary.Properties.Resources.go_bottom;
            this.cmsRobotInstruction_Bottom.Name = "cmsRobotInstruction_Bottom";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // cmsRobotInstruction_Delete
            // 
            resources.ApplyResources(this.cmsRobotInstruction_Delete, "cmsRobotInstruction_Delete");
            this.cmsRobotInstruction_Delete.Image = global::WPELibrary.Properties.Resources.Delete;
            this.cmsRobotInstruction_Delete.Name = "cmsRobotInstruction_Delete";
            // 
            // cmsRobotInstruction_CleanUp
            // 
            resources.ApplyResources(this.cmsRobotInstruction_CleanUp, "cmsRobotInstruction_CleanUp");
            this.cmsRobotInstruction_CleanUp.Image = global::WPELibrary.Properties.Resources.Trash_can16;
            this.cmsRobotInstruction_CleanUp.Name = "cmsRobotInstruction_CleanUp";
            // 
            // tcRobotInstruction
            // 
            resources.ApplyResources(this.tcRobotInstruction, "tcRobotInstruction");
            this.tcRobotInstruction.Controls.Add(this.tpInstruction_Socket);
            this.tcRobotInstruction.Controls.Add(this.tpInstruction_Control);
            this.tcRobotInstruction.Controls.Add(this.tpInstruction_keyboard);
            this.tcRobotInstruction.Controls.Add(this.tpInstruction_Mouse);
            this.tcRobotInstruction.Name = "tcRobotInstruction";
            this.tcRobotInstruction.SelectedIndex = 0;
            // 
            // tpInstruction_Socket
            // 
            resources.ApplyResources(this.tpInstruction_Socket, "tpInstruction_Socket");
            this.tpInstruction_Socket.BackColor = System.Drawing.SystemColors.Control;
            this.tpInstruction_Socket.Controls.Add(this.tlpInstruction_Socket);
            this.tpInstruction_Socket.Name = "tpInstruction_Socket";
            // 
            // tlpInstruction_Socket
            // 
            resources.ApplyResources(this.tlpInstruction_Socket, "tlpInstruction_Socket");
            this.tlpInstruction_Socket.Controls.Add(this.gbSpecifySend, 1, 0);
            this.tlpInstruction_Socket.Controls.Add(this.gbSend, 0, 0);
            this.tlpInstruction_Socket.Name = "tlpInstruction_Socket";
            // 
            // gbSpecifySend
            // 
            resources.ApplyResources(this.gbSpecifySend, "gbSpecifySend");
            this.gbSpecifySend.Controls.Add(this.tlpSpecifySend);
            this.gbSpecifySend.Name = "gbSpecifySend";
            this.gbSpecifySend.TabStop = false;
            // 
            // tlpSpecifySend
            // 
            resources.ApplyResources(this.tlpSpecifySend, "tlpSpecifySend");
            this.tlpSpecifySend.Controls.Add(this.bSend_SocketList, 2, 0);
            this.tlpSpecifySend.Controls.Add(this.lSpecifySend_SocketList, 0, 0);
            this.tlpSpecifySend.Name = "tlpSpecifySend";
            // 
            // bSend_SocketList
            // 
            resources.ApplyResources(this.bSend_SocketList, "bSend_SocketList");
            this.bSend_SocketList.Name = "bSend_SocketList";
            this.bSend_SocketList.UseVisualStyleBackColor = true;
            this.bSend_SocketList.Click += new System.EventHandler(this.bSend_SocketList_Click);
            // 
            // lSpecifySend_SocketList
            // 
            resources.ApplyResources(this.lSpecifySend_SocketList, "lSpecifySend_SocketList");
            this.lSpecifySend_SocketList.Name = "lSpecifySend_SocketList";
            // 
            // gbSend
            // 
            resources.ApplyResources(this.gbSend, "gbSend");
            this.gbSend.Controls.Add(this.tlpSend);
            this.gbSend.Name = "gbSend";
            this.gbSend.TabStop = false;
            // 
            // tlpSend
            // 
            resources.ApplyResources(this.tlpSend, "tlpSend");
            this.tlpSend.Controls.Add(this.nudSendSocket, 3, 0);
            this.tlpSend.Controls.Add(this.lSendSocket, 2, 0);
            this.tlpSend.Controls.Add(this.nudSendInterval, 3, 1);
            this.tlpSend.Controls.Add(this.lSendInterval, 2, 1);
            this.tlpSend.Controls.Add(this.nudSendTimes, 1, 1);
            this.tlpSend.Controls.Add(this.lSendTimes, 0, 1);
            this.tlpSend.Controls.Add(this.lSendIndex, 0, 0);
            this.tlpSend.Controls.Add(this.nudSendIndex, 1, 0);
            this.tlpSend.Controls.Add(this.bSend, 5, 1);
            this.tlpSend.Name = "tlpSend";
            // 
            // nudSendSocket
            // 
            resources.ApplyResources(this.nudSendSocket, "nudSendSocket");
            this.nudSendSocket.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSendSocket.Name = "nudSendSocket";
            // 
            // lSendSocket
            // 
            resources.ApplyResources(this.lSendSocket, "lSendSocket");
            this.lSendSocket.Name = "lSendSocket";
            // 
            // nudSendInterval
            // 
            resources.ApplyResources(this.nudSendInterval, "nudSendInterval");
            this.nudSendInterval.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSendInterval.Name = "nudSendInterval";
            this.nudSendInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lSendInterval
            // 
            resources.ApplyResources(this.lSendInterval, "lSendInterval");
            this.lSendInterval.Name = "lSendInterval";
            // 
            // nudSendTimes
            // 
            resources.ApplyResources(this.nudSendTimes, "nudSendTimes");
            this.nudSendTimes.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSendTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSendTimes.Name = "nudSendTimes";
            this.nudSendTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lSendTimes
            // 
            resources.ApplyResources(this.lSendTimes, "lSendTimes");
            this.lSendTimes.Name = "lSendTimes";
            // 
            // lSendIndex
            // 
            resources.ApplyResources(this.lSendIndex, "lSendIndex");
            this.lSendIndex.Name = "lSendIndex";
            // 
            // nudSendIndex
            // 
            resources.ApplyResources(this.nudSendIndex, "nudSendIndex");
            this.nudSendIndex.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSendIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSendIndex.Name = "nudSendIndex";
            this.nudSendIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bSend
            // 
            resources.ApplyResources(this.bSend, "bSend");
            this.bSend.Name = "bSend";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tpInstruction_Control
            // 
            resources.ApplyResources(this.tpInstruction_Control, "tpInstruction_Control");
            this.tpInstruction_Control.BackColor = System.Drawing.SystemColors.Control;
            this.tpInstruction_Control.Controls.Add(this.tlpInstruction_Control);
            this.tpInstruction_Control.Name = "tpInstruction_Control";
            // 
            // tlpInstruction_Control
            // 
            resources.ApplyResources(this.tlpInstruction_Control, "tlpInstruction_Control");
            this.tlpInstruction_Control.Controls.Add(this.gbLoop, 1, 0);
            this.tlpInstruction_Control.Controls.Add(this.gbDelay, 0, 0);
            this.tlpInstruction_Control.Name = "tlpInstruction_Control";
            // 
            // gbLoop
            // 
            resources.ApplyResources(this.gbLoop, "gbLoop");
            this.gbLoop.Controls.Add(this.tlpLoop);
            this.gbLoop.Name = "gbLoop";
            this.gbLoop.TabStop = false;
            // 
            // tlpLoop
            // 
            resources.ApplyResources(this.tlpLoop, "tlpLoop");
            this.tlpLoop.Controls.Add(this.lLoop, 0, 0);
            this.tlpLoop.Controls.Add(this.bLoopEnd, 5, 0);
            this.tlpLoop.Controls.Add(this.bLoopStart, 3, 0);
            this.tlpLoop.Controls.Add(this.nudLoop, 1, 0);
            this.tlpLoop.Name = "tlpLoop";
            // 
            // lLoop
            // 
            resources.ApplyResources(this.lLoop, "lLoop");
            this.lLoop.Name = "lLoop";
            // 
            // bLoopEnd
            // 
            resources.ApplyResources(this.bLoopEnd, "bLoopEnd");
            this.bLoopEnd.Name = "bLoopEnd";
            this.bLoopEnd.UseVisualStyleBackColor = true;
            this.bLoopEnd.Click += new System.EventHandler(this.bLoopEnd_Click);
            // 
            // bLoopStart
            // 
            resources.ApplyResources(this.bLoopStart, "bLoopStart");
            this.bLoopStart.Name = "bLoopStart";
            this.bLoopStart.UseVisualStyleBackColor = true;
            this.bLoopStart.Click += new System.EventHandler(this.bLoopStart_Click);
            // 
            // nudLoop
            // 
            resources.ApplyResources(this.nudLoop, "nudLoop");
            this.nudLoop.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudLoop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoop.Name = "nudLoop";
            this.nudLoop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbDelay
            // 
            resources.ApplyResources(this.gbDelay, "gbDelay");
            this.gbDelay.Controls.Add(this.tlpDelay);
            this.gbDelay.Name = "gbDelay";
            this.gbDelay.TabStop = false;
            // 
            // tlpDelay
            // 
            resources.ApplyResources(this.tlpDelay, "tlpDelay");
            this.tlpDelay.Controls.Add(this.lDelay, 0, 0);
            this.tlpDelay.Controls.Add(this.bDelay, 3, 0);
            this.tlpDelay.Controls.Add(this.nudDelay, 1, 0);
            this.tlpDelay.Name = "tlpDelay";
            // 
            // lDelay
            // 
            resources.ApplyResources(this.lDelay, "lDelay");
            this.lDelay.Name = "lDelay";
            // 
            // bDelay
            // 
            resources.ApplyResources(this.bDelay, "bDelay");
            this.bDelay.Name = "bDelay";
            this.bDelay.UseVisualStyleBackColor = true;
            this.bDelay.Click += new System.EventHandler(this.bDelay_Click);
            // 
            // nudDelay
            // 
            resources.ApplyResources(this.nudDelay, "nudDelay");
            this.nudDelay.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tpInstruction_keyboard
            // 
            resources.ApplyResources(this.tpInstruction_keyboard, "tpInstruction_keyboard");
            this.tpInstruction_keyboard.BackColor = System.Drawing.SystemColors.Control;
            this.tpInstruction_keyboard.Controls.Add(this.tlpInstruction_keyboard);
            this.tpInstruction_keyboard.Name = "tpInstruction_keyboard";
            // 
            // tlpInstruction_keyboard
            // 
            resources.ApplyResources(this.tlpInstruction_keyboard, "tlpInstruction_keyboard");
            this.tlpInstruction_keyboard.Controls.Add(this.gbKeyboard, 0, 0);
            this.tlpInstruction_keyboard.Controls.Add(this.tlpKeyBoardCombine, 1, 0);
            this.tlpInstruction_keyboard.Name = "tlpInstruction_keyboard";
            // 
            // gbKeyboard
            // 
            resources.ApplyResources(this.gbKeyboard, "gbKeyboard");
            this.gbKeyboard.Controls.Add(this.tlpKeyboard);
            this.gbKeyboard.Name = "gbKeyboard";
            this.gbKeyboard.TabStop = false;
            // 
            // tlpKeyboard
            // 
            resources.ApplyResources(this.tlpKeyboard, "tlpKeyboard");
            this.tlpKeyboard.Controls.Add(this.cbbKeyBoard_KeyType, 3, 0);
            this.tlpKeyboard.Controls.Add(this.lKeyBoard_KeyType, 2, 0);
            this.tlpKeyboard.Controls.Add(this.nudKeyBoard_Interval, 3, 1);
            this.tlpKeyboard.Controls.Add(this.lKeyBoard_Interval, 2, 1);
            this.tlpKeyboard.Controls.Add(this.lKeyBoard_Times, 0, 1);
            this.tlpKeyboard.Controls.Add(this.lKeyBoard_KeyCode, 0, 0);
            this.tlpKeyboard.Controls.Add(this.txtKeyBoard_KeyCode, 1, 0);
            this.tlpKeyboard.Controls.Add(this.nudKeyBoard_Times, 1, 1);
            this.tlpKeyboard.Controls.Add(this.bKeyBoard, 5, 1);
            this.tlpKeyboard.Name = "tlpKeyboard";
            // 
            // cbbKeyBoard_KeyType
            // 
            resources.ApplyResources(this.cbbKeyBoard_KeyType, "cbbKeyBoard_KeyType");
            this.cbbKeyBoard_KeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyBoard_KeyType.FormattingEnabled = true;
            this.cbbKeyBoard_KeyType.Items.AddRange(new object[] {
            resources.GetString("cbbKeyBoard_KeyType.Items"),
            resources.GetString("cbbKeyBoard_KeyType.Items1"),
            resources.GetString("cbbKeyBoard_KeyType.Items2")});
            this.cbbKeyBoard_KeyType.Name = "cbbKeyBoard_KeyType";
            // 
            // lKeyBoard_KeyType
            // 
            resources.ApplyResources(this.lKeyBoard_KeyType, "lKeyBoard_KeyType");
            this.lKeyBoard_KeyType.Name = "lKeyBoard_KeyType";
            // 
            // nudKeyBoard_Interval
            // 
            resources.ApplyResources(this.nudKeyBoard_Interval, "nudKeyBoard_Interval");
            this.nudKeyBoard_Interval.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudKeyBoard_Interval.Name = "nudKeyBoard_Interval";
            this.nudKeyBoard_Interval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lKeyBoard_Interval
            // 
            resources.ApplyResources(this.lKeyBoard_Interval, "lKeyBoard_Interval");
            this.lKeyBoard_Interval.Name = "lKeyBoard_Interval";
            // 
            // lKeyBoard_Times
            // 
            resources.ApplyResources(this.lKeyBoard_Times, "lKeyBoard_Times");
            this.lKeyBoard_Times.Name = "lKeyBoard_Times";
            // 
            // lKeyBoard_KeyCode
            // 
            resources.ApplyResources(this.lKeyBoard_KeyCode, "lKeyBoard_KeyCode");
            this.lKeyBoard_KeyCode.Name = "lKeyBoard_KeyCode";
            // 
            // txtKeyBoard_KeyCode
            // 
            resources.ApplyResources(this.txtKeyBoard_KeyCode, "txtKeyBoard_KeyCode");
            this.txtKeyBoard_KeyCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyBoard_KeyCode.Name = "txtKeyBoard_KeyCode";
            this.txtKeyBoard_KeyCode.ReadOnly = true;
            this.txtKeyBoard_KeyCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyBoard_Key_KeyDown);
            // 
            // nudKeyBoard_Times
            // 
            resources.ApplyResources(this.nudKeyBoard_Times, "nudKeyBoard_Times");
            this.nudKeyBoard_Times.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudKeyBoard_Times.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKeyBoard_Times.Name = "nudKeyBoard_Times";
            this.nudKeyBoard_Times.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bKeyBoard
            // 
            resources.ApplyResources(this.bKeyBoard, "bKeyBoard");
            this.bKeyBoard.Name = "bKeyBoard";
            this.bKeyBoard.UseVisualStyleBackColor = true;
            this.bKeyBoard.Click += new System.EventHandler(this.bKeyBoard_Click);
            // 
            // tlpKeyBoardCombine
            // 
            resources.ApplyResources(this.tlpKeyBoardCombine, "tlpKeyBoardCombine");
            this.tlpKeyBoardCombine.Controls.Add(this.gbKeyboard_Text, 0, 1);
            this.tlpKeyBoardCombine.Controls.Add(this.gbKeyboard_combination, 0, 0);
            this.tlpKeyBoardCombine.Name = "tlpKeyBoardCombine";
            // 
            // gbKeyboard_Text
            // 
            resources.ApplyResources(this.gbKeyboard_Text, "gbKeyboard_Text");
            this.gbKeyboard_Text.Controls.Add(this.tlpKeyboard_Text);
            this.gbKeyboard_Text.Name = "gbKeyboard_Text";
            this.gbKeyboard_Text.TabStop = false;
            // 
            // tlpKeyboard_Text
            // 
            resources.ApplyResources(this.tlpKeyboard_Text, "tlpKeyboard_Text");
            this.tlpKeyboard_Text.Controls.Add(this.txtKeyboard_Text, 0, 0);
            this.tlpKeyboard_Text.Controls.Add(this.bKeyboard_Text, 2, 0);
            this.tlpKeyboard_Text.Name = "tlpKeyboard_Text";
            // 
            // txtKeyboard_Text
            // 
            resources.ApplyResources(this.txtKeyboard_Text, "txtKeyboard_Text");
            this.txtKeyboard_Text.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyboard_Text.Name = "txtKeyboard_Text";
            // 
            // bKeyboard_Text
            // 
            resources.ApplyResources(this.bKeyboard_Text, "bKeyboard_Text");
            this.bKeyboard_Text.Name = "bKeyboard_Text";
            this.bKeyboard_Text.UseVisualStyleBackColor = true;
            this.bKeyboard_Text.Click += new System.EventHandler(this.bKeyboard_Text_Click);
            // 
            // gbKeyboard_combination
            // 
            resources.ApplyResources(this.gbKeyboard_combination, "gbKeyboard_combination");
            this.gbKeyboard_combination.Controls.Add(this.tlpKeyboard_combination);
            this.gbKeyboard_combination.Name = "gbKeyboard_combination";
            this.gbKeyboard_combination.TabStop = false;
            // 
            // tlpKeyboard_combination
            // 
            resources.ApplyResources(this.tlpKeyboard_combination, "tlpKeyboard_combination");
            this.tlpKeyboard_combination.Controls.Add(this.lKeyboard_combination, 0, 0);
            this.tlpKeyboard_combination.Controls.Add(this.txtKeyboard_combination, 1, 0);
            this.tlpKeyboard_combination.Controls.Add(this.bKeyboard_combination, 3, 0);
            this.tlpKeyboard_combination.Name = "tlpKeyboard_combination";
            // 
            // lKeyboard_combination
            // 
            resources.ApplyResources(this.lKeyboard_combination, "lKeyboard_combination");
            this.lKeyboard_combination.Name = "lKeyboard_combination";
            // 
            // txtKeyboard_combination
            // 
            resources.ApplyResources(this.txtKeyboard_combination, "txtKeyboard_combination");
            this.txtKeyboard_combination.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyboard_combination.Name = "txtKeyboard_combination";
            this.txtKeyboard_combination.ReadOnly = true;
            this.txtKeyboard_combination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyboard_combination_KeyDown);
            this.txtKeyboard_combination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyboard_combination_KeyUp);
            // 
            // bKeyboard_combination
            // 
            resources.ApplyResources(this.bKeyboard_combination, "bKeyboard_combination");
            this.bKeyboard_combination.Name = "bKeyboard_combination";
            this.bKeyboard_combination.UseVisualStyleBackColor = true;
            this.bKeyboard_combination.Click += new System.EventHandler(this.bKeyboard_combination_Click);
            // 
            // tpInstruction_Mouse
            // 
            resources.ApplyResources(this.tpInstruction_Mouse, "tpInstruction_Mouse");
            this.tpInstruction_Mouse.BackColor = System.Drawing.SystemColors.Control;
            this.tpInstruction_Mouse.Controls.Add(this.tlpInstruction_Mouse);
            this.tpInstruction_Mouse.Name = "tpInstruction_Mouse";
            // 
            // tlpInstruction_Mouse
            // 
            resources.ApplyResources(this.tlpInstruction_Mouse, "tlpInstruction_Mouse");
            this.tlpInstruction_Mouse.Controls.Add(this.gbMouseWheel, 1, 0);
            this.tlpInstruction_Mouse.Controls.Add(this.gbMouseMove, 2, 0);
            this.tlpInstruction_Mouse.Controls.Add(this.gbMouse, 0, 0);
            this.tlpInstruction_Mouse.Name = "tlpInstruction_Mouse";
            // 
            // gbMouseWheel
            // 
            resources.ApplyResources(this.gbMouseWheel, "gbMouseWheel");
            this.gbMouseWheel.Controls.Add(this.tlpMouseWheel);
            this.gbMouseWheel.Name = "gbMouseWheel";
            this.gbMouseWheel.TabStop = false;
            // 
            // tlpMouseWheel
            // 
            resources.ApplyResources(this.tlpMouseWheel, "tlpMouseWheel");
            this.tlpMouseWheel.Controls.Add(this.lMouseWheel_Distance, 0, 1);
            this.tlpMouseWheel.Controls.Add(this.lMouseWheel_Direction, 0, 0);
            this.tlpMouseWheel.Controls.Add(this.nudMouseWheel_Distance, 1, 1);
            this.tlpMouseWheel.Controls.Add(this.bMouseWheel, 4, 0);
            this.tlpMouseWheel.Controls.Add(this.cbbMouseWheel_Direction, 1, 0);
            this.tlpMouseWheel.Name = "tlpMouseWheel";
            // 
            // lMouseWheel_Distance
            // 
            resources.ApplyResources(this.lMouseWheel_Distance, "lMouseWheel_Distance");
            this.lMouseWheel_Distance.Name = "lMouseWheel_Distance";
            // 
            // lMouseWheel_Direction
            // 
            resources.ApplyResources(this.lMouseWheel_Direction, "lMouseWheel_Direction");
            this.lMouseWheel_Direction.Name = "lMouseWheel_Direction";
            // 
            // nudMouseWheel_Distance
            // 
            resources.ApplyResources(this.nudMouseWheel_Distance, "nudMouseWheel_Distance");
            this.nudMouseWheel_Distance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMouseWheel_Distance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMouseWheel_Distance.Name = "nudMouseWheel_Distance";
            this.nudMouseWheel_Distance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bMouseWheel
            // 
            resources.ApplyResources(this.bMouseWheel, "bMouseWheel");
            this.bMouseWheel.Name = "bMouseWheel";
            this.bMouseWheel.UseVisualStyleBackColor = true;
            this.bMouseWheel.Click += new System.EventHandler(this.bMouseWheel_Click);
            // 
            // cbbMouseWheel_Direction
            // 
            resources.ApplyResources(this.cbbMouseWheel_Direction, "cbbMouseWheel_Direction");
            this.cbbMouseWheel_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMouseWheel_Direction.FormattingEnabled = true;
            this.cbbMouseWheel_Direction.Items.AddRange(new object[] {
            resources.GetString("cbbMouseWheel_Direction.Items"),
            resources.GetString("cbbMouseWheel_Direction.Items1")});
            this.cbbMouseWheel_Direction.Name = "cbbMouseWheel_Direction";
            // 
            // gbMouseMove
            // 
            resources.ApplyResources(this.gbMouseMove, "gbMouseMove");
            this.gbMouseMove.Controls.Add(this.tlpMouseMove);
            this.gbMouseMove.Name = "gbMouseMove";
            this.gbMouseMove.TabStop = false;
            // 
            // tlpMouseMove
            // 
            resources.ApplyResources(this.tlpMouseMove, "tlpMouseMove");
            this.tlpMouseMove.Controls.Add(this.rbMoveBy, 1, 0);
            this.tlpMouseMove.Controls.Add(this.nudMouseMove_Y, 3, 1);
            this.tlpMouseMove.Controls.Add(this.lMouseMove_Y, 2, 1);
            this.tlpMouseMove.Controls.Add(this.bMouseMove, 5, 1);
            this.tlpMouseMove.Controls.Add(this.nudMouseMove_X, 1, 1);
            this.tlpMouseMove.Controls.Add(this.lMouseMove_X, 0, 1);
            this.tlpMouseMove.Controls.Add(this.rbMoveTo, 0, 0);
            this.tlpMouseMove.Name = "tlpMouseMove";
            // 
            // rbMoveBy
            // 
            resources.ApplyResources(this.rbMoveBy, "rbMoveBy");
            this.rbMoveBy.Name = "rbMoveBy";
            this.rbMoveBy.UseVisualStyleBackColor = true;
            // 
            // nudMouseMove_Y
            // 
            resources.ApplyResources(this.nudMouseMove_Y, "nudMouseMove_Y");
            this.nudMouseMove_Y.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMouseMove_Y.Name = "nudMouseMove_Y";
            // 
            // lMouseMove_Y
            // 
            resources.ApplyResources(this.lMouseMove_Y, "lMouseMove_Y");
            this.lMouseMove_Y.Name = "lMouseMove_Y";
            // 
            // bMouseMove
            // 
            resources.ApplyResources(this.bMouseMove, "bMouseMove");
            this.bMouseMove.Name = "bMouseMove";
            this.bMouseMove.UseVisualStyleBackColor = true;
            this.bMouseMove.Click += new System.EventHandler(this.bMouseMove_Click);
            // 
            // nudMouseMove_X
            // 
            resources.ApplyResources(this.nudMouseMove_X, "nudMouseMove_X");
            this.nudMouseMove_X.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMouseMove_X.Name = "nudMouseMove_X";
            // 
            // lMouseMove_X
            // 
            resources.ApplyResources(this.lMouseMove_X, "lMouseMove_X");
            this.lMouseMove_X.Name = "lMouseMove_X";
            // 
            // rbMoveTo
            // 
            resources.ApplyResources(this.rbMoveTo, "rbMoveTo");
            this.rbMoveTo.Checked = true;
            this.rbMoveTo.Name = "rbMoveTo";
            this.rbMoveTo.TabStop = true;
            this.rbMoveTo.UseVisualStyleBackColor = true;
            // 
            // gbMouse
            // 
            resources.ApplyResources(this.gbMouse, "gbMouse");
            this.gbMouse.Controls.Add(this.tlpMouse);
            this.gbMouse.Name = "gbMouse";
            this.gbMouse.TabStop = false;
            // 
            // tlpMouse
            // 
            resources.ApplyResources(this.tlpMouse, "tlpMouse");
            this.tlpMouse.Controls.Add(this.nudMouse_Interval, 1, 2);
            this.tlpMouse.Controls.Add(this.lMouse_Interval, 0, 2);
            this.tlpMouse.Controls.Add(this.lMouse_Times, 0, 1);
            this.tlpMouse.Controls.Add(this.lMouse, 0, 0);
            this.tlpMouse.Controls.Add(this.nudMouse_Times, 1, 1);
            this.tlpMouse.Controls.Add(this.bMouse, 4, 0);
            this.tlpMouse.Controls.Add(this.cbbMouse, 1, 0);
            this.tlpMouse.Name = "tlpMouse";
            // 
            // nudMouse_Interval
            // 
            resources.ApplyResources(this.nudMouse_Interval, "nudMouse_Interval");
            this.nudMouse_Interval.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMouse_Interval.Name = "nudMouse_Interval";
            this.nudMouse_Interval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lMouse_Interval
            // 
            resources.ApplyResources(this.lMouse_Interval, "lMouse_Interval");
            this.lMouse_Interval.Name = "lMouse_Interval";
            // 
            // lMouse_Times
            // 
            resources.ApplyResources(this.lMouse_Times, "lMouse_Times");
            this.lMouse_Times.Name = "lMouse_Times";
            // 
            // lMouse
            // 
            resources.ApplyResources(this.lMouse, "lMouse");
            this.lMouse.Name = "lMouse";
            // 
            // nudMouse_Times
            // 
            resources.ApplyResources(this.nudMouse_Times, "nudMouse_Times");
            this.nudMouse_Times.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMouse_Times.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMouse_Times.Name = "nudMouse_Times";
            this.nudMouse_Times.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bMouse
            // 
            resources.ApplyResources(this.bMouse, "bMouse");
            this.bMouse.Name = "bMouse";
            this.bMouse.UseVisualStyleBackColor = true;
            this.bMouse.Click += new System.EventHandler(this.bMouse_Click);
            // 
            // cbbMouse
            // 
            resources.ApplyResources(this.cbbMouse, "cbbMouse");
            this.cbbMouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMouse.FormattingEnabled = true;
            this.cbbMouse.Items.AddRange(new object[] {
            resources.GetString("cbbMouse.Items"),
            resources.GetString("cbbMouse.Items1"),
            resources.GetString("cbbMouse.Items2"),
            resources.GetString("cbbMouse.Items3"),
            resources.GetString("cbbMouse.Items4"),
            resources.GetString("cbbMouse.Items5"),
            resources.GetString("cbbMouse.Items6"),
            resources.GetString("cbbMouse.Items7")});
            this.cbbMouse.Name = "cbbMouse";
            // 
            // tlpButton
            // 
            resources.ApplyResources(this.tlpButton, "tlpButton");
            this.tlpButton.Controls.Add(this.bStop, 3, 0);
            this.tlpButton.Controls.Add(this.bExecute, 1, 0);
            this.tlpButton.Controls.Add(this.bClose, 7, 0);
            this.tlpButton.Controls.Add(this.bSave, 5, 0);
            this.tlpButton.Name = "tlpButton";
            // 
            // bStop
            // 
            resources.ApplyResources(this.bStop, "bStop");
            this.bStop.Name = "bStop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bExecute
            // 
            resources.ApplyResources(this.bExecute, "bExecute");
            this.bExecute.Name = "bExecute";
            this.bExecute.UseVisualStyleBackColor = true;
            this.bExecute.Click += new System.EventHandler(this.bExecute_Click);
            // 
            // bClose
            // 
            resources.ApplyResources(this.bClose, "bClose");
            this.bClose.Name = "bClose";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            resources.ApplyResources(this.bSave, "bSave");
            this.bSave.Name = "bSave";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // gbExecute
            // 
            resources.ApplyResources(this.gbExecute, "gbExecute");
            this.gbExecute.Controls.Add(this.txtExecute);
            this.gbExecute.Name = "gbExecute";
            this.gbExecute.TabStop = false;
            // 
            // txtExecute
            // 
            resources.ApplyResources(this.txtExecute, "txtExecute");
            this.txtExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtExecute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExecute.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtExecute.Name = "txtExecute";
            this.txtExecute.ReadOnly = true;
            // 
            // Socket_RobotForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tlpRobotForm);
            this.DoubleBuffered = true;
            this.Name = "Socket_RobotForm";
            this.Load += new System.EventHandler(this.Socket_RobotForm_Load);
            this.tlpRobotForm.ResumeLayout(false);
            this.tlpRobotForm.PerformLayout();
            this.ssRobotInstruction.ResumeLayout(false);
            this.ssRobotInstruction.PerformLayout();
            this.tlpListInfo.ResumeLayout(false);
            this.gbSendList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendList)).EndInit();
            this.tlpRobotInfo.ResumeLayout(false);
            this.gbRobotName.ResumeLayout(false);
            this.gbRobotName.PerformLayout();
            this.gbRobotInstruction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRobotInstruction)).EndInit();
            this.cmsRobotInstruction.ResumeLayout(false);
            this.tcRobotInstruction.ResumeLayout(false);
            this.tpInstruction_Socket.ResumeLayout(false);
            this.tlpInstruction_Socket.ResumeLayout(false);
            this.gbSpecifySend.ResumeLayout(false);
            this.tlpSpecifySend.ResumeLayout(false);
            this.tlpSpecifySend.PerformLayout();
            this.gbSend.ResumeLayout(false);
            this.tlpSend.ResumeLayout(false);
            this.tlpSend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendSocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendIndex)).EndInit();
            this.tpInstruction_Control.ResumeLayout(false);
            this.tlpInstruction_Control.ResumeLayout(false);
            this.gbLoop.ResumeLayout(false);
            this.tlpLoop.ResumeLayout(false);
            this.tlpLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoop)).EndInit();
            this.gbDelay.ResumeLayout(false);
            this.tlpDelay.ResumeLayout(false);
            this.tlpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.tpInstruction_keyboard.ResumeLayout(false);
            this.tlpInstruction_keyboard.ResumeLayout(false);
            this.gbKeyboard.ResumeLayout(false);
            this.tlpKeyboard.ResumeLayout(false);
            this.tlpKeyboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeyBoard_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKeyBoard_Times)).EndInit();
            this.tlpKeyBoardCombine.ResumeLayout(false);
            this.gbKeyboard_Text.ResumeLayout(false);
            this.tlpKeyboard_Text.ResumeLayout(false);
            this.tlpKeyboard_Text.PerformLayout();
            this.gbKeyboard_combination.ResumeLayout(false);
            this.tlpKeyboard_combination.ResumeLayout(false);
            this.tlpKeyboard_combination.PerformLayout();
            this.tpInstruction_Mouse.ResumeLayout(false);
            this.tlpInstruction_Mouse.ResumeLayout(false);
            this.gbMouseWheel.ResumeLayout(false);
            this.tlpMouseWheel.ResumeLayout(false);
            this.tlpMouseWheel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseWheel_Distance)).EndInit();
            this.gbMouseMove.ResumeLayout(false);
            this.tlpMouseMove.ResumeLayout(false);
            this.tlpMouseMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseMove_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseMove_X)).EndInit();
            this.gbMouse.ResumeLayout(false);
            this.tlpMouse.ResumeLayout(false);
            this.tlpMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouse_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouse_Times)).EndInit();
            this.tlpButton.ResumeLayout(false);
            this.gbExecute.ResumeLayout(false);
            this.gbExecute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRobotForm;
        private System.Windows.Forms.TableLayoutPanel tlpListInfo;
        private System.Windows.Forms.TabControl tcRobotInstruction;
        private System.Windows.Forms.TabPage tpInstruction_Socket;
        private System.Windows.Forms.TableLayoutPanel tlpInstruction_Socket;
        private System.Windows.Forms.GroupBox gbSend;
        private System.Windows.Forms.TableLayoutPanel tlpSend;
        private System.Windows.Forms.Label lSendIndex;
        private System.Windows.Forms.NumericUpDown nudSendIndex;
        private System.Windows.Forms.Label lSendTimes;
        private System.Windows.Forms.NumericUpDown nudSendTimes;
        private System.Windows.Forms.NumericUpDown nudSendInterval;
        private System.Windows.Forms.Label lSendInterval;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.ContextMenuStrip cmsRobotInstruction;
        private System.Windows.Forms.ToolStripMenuItem cmsRobotInstruction_Top;
        private System.Windows.Forms.ToolStripMenuItem cmsRobotInstruction_Bottom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsRobotInstruction_Up;
        private System.Windows.Forms.ToolStripMenuItem cmsRobotInstruction_Down;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmsRobotInstruction_Delete;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TableLayoutPanel tlpRobotInfo;
        private System.Windows.Forms.GroupBox gbRobotInstruction;
        private System.Windows.Forms.DataGridView dgvRobotInstruction;
        private System.Windows.Forms.GroupBox gbSendList;
        private System.Windows.Forms.DataGridView dgvSendList;
        private System.Windows.Forms.GroupBox gbRobotName;
        private System.Windows.Forms.TextBox txtRobotName;
        private System.Windows.Forms.ToolStripMenuItem cmsRobotInstruction_CleanUp;
        private System.Windows.Forms.Button bExecute;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRobotInstruction_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRobotInstruction_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRobotInstruction_Content;
        private System.Windows.Forms.NumericUpDown nudSendSocket;
        private System.Windows.Forms.Label lSendSocket;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.StatusStrip ssRobotInstruction;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Total;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Total_Value;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Split1;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Success;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Success_Value;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Fail;
        private System.Windows.Forms.ToolStripStatusLabel ssRobotInstruction_Fail_Value;
        private System.Windows.Forms.TabPage tpInstruction_keyboard;
        private System.Windows.Forms.TableLayoutPanel tlpInstruction_keyboard;
        private System.Windows.Forms.TabPage tpInstruction_Mouse;
        private System.Windows.Forms.TableLayoutPanel tlpInstruction_Mouse;
        private System.Windows.Forms.GroupBox gbKeyboard;
        private System.Windows.Forms.GroupBox gbMouseMove;
        private System.Windows.Forms.GroupBox gbMouse;
        private System.Windows.Forms.TableLayoutPanel tlpKeyboard;
        private System.Windows.Forms.Label lKeyBoard_Times;
        private System.Windows.Forms.Label lKeyBoard_KeyCode;
        private System.Windows.Forms.TextBox txtKeyBoard_KeyCode;
        private System.Windows.Forms.NumericUpDown nudKeyBoard_Times;
        private System.Windows.Forms.Button bKeyBoard;
        private System.Windows.Forms.NumericUpDown nudKeyBoard_Interval;
        private System.Windows.Forms.Label lKeyBoard_Interval;
        private System.Windows.Forms.GroupBox gbExecute;
        private System.Windows.Forms.TextBox txtExecute;
        private System.Windows.Forms.TableLayoutPanel tlpMouse;
        private System.Windows.Forms.NumericUpDown nudMouse_Interval;
        private System.Windows.Forms.Label lMouse_Interval;
        private System.Windows.Forms.Label lMouse_Times;
        private System.Windows.Forms.Label lMouse;
        private System.Windows.Forms.NumericUpDown nudMouse_Times;
        private System.Windows.Forms.Button bMouse;
        private System.Windows.Forms.ComboBox cbbMouse;
        private System.Windows.Forms.GroupBox gbMouseWheel;
        private System.Windows.Forms.TableLayoutPanel tlpMouseWheel;
        private System.Windows.Forms.Label lMouseWheel_Distance;
        private System.Windows.Forms.Label lMouseWheel_Direction;
        private System.Windows.Forms.NumericUpDown nudMouseWheel_Distance;
        private System.Windows.Forms.Button bMouseWheel;
        private System.Windows.Forms.ComboBox cbbMouseWheel_Direction;
        private System.Windows.Forms.TableLayoutPanel tlpMouseMove;
        private System.Windows.Forms.NumericUpDown nudMouseMove_X;
        private System.Windows.Forms.Label lMouseMove_X;
        private System.Windows.Forms.NumericUpDown nudMouseMove_Y;
        private System.Windows.Forms.Label lMouseMove_Y;
        private System.Windows.Forms.Button bMouseMove;
        private System.Windows.Forms.TabPage tpInstruction_Control;
        private System.Windows.Forms.TableLayoutPanel tlpInstruction_Control;
        private System.Windows.Forms.GroupBox gbLoop;
        private System.Windows.Forms.TableLayoutPanel tlpLoop;
        private System.Windows.Forms.Label lLoop;
        private System.Windows.Forms.Button bLoopEnd;
        private System.Windows.Forms.Button bLoopStart;
        private System.Windows.Forms.NumericUpDown nudLoop;
        private System.Windows.Forms.GroupBox gbDelay;
        private System.Windows.Forms.TableLayoutPanel tlpDelay;
        private System.Windows.Forms.Label lDelay;
        private System.Windows.Forms.Button bDelay;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.ComboBox cbbKeyBoard_KeyType;
        private System.Windows.Forms.Label lKeyBoard_KeyType;
        private System.Windows.Forms.TableLayoutPanel tlpKeyBoardCombine;
        private System.Windows.Forms.GroupBox gbKeyboard_combination;
        private System.Windows.Forms.TableLayoutPanel tlpKeyboard_combination;
        private System.Windows.Forms.Label lKeyboard_combination;
        private System.Windows.Forms.TextBox txtKeyboard_combination;
        private System.Windows.Forms.Button bKeyboard_combination;
        private System.Windows.Forms.GroupBox gbKeyboard_Text;
        private System.Windows.Forms.TableLayoutPanel tlpKeyboard_Text;
        private System.Windows.Forms.TextBox txtKeyboard_Text;
        private System.Windows.Forms.Button bKeyboard_Text;
        private System.Windows.Forms.RadioButton rbMoveBy;
        private System.Windows.Forms.RadioButton rbMoveTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSendList_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSocket;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIPTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLen;
        private System.Windows.Forms.GroupBox gbSpecifySend;
        private System.Windows.Forms.TableLayoutPanel tlpSpecifySend;
        private System.Windows.Forms.Label lSpecifySend_SocketList;
        private System.Windows.Forms.Button bSend_SocketList;
    }
}