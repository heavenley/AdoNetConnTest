//====================================================================
//
// COPYRIGHT (C) 2001 OPINIONATEDGEEK
//
// The contents of this file are subject to License from OpinionatedGeek;
// you may not use this file except in compliance with the License.
// You may obtain a License from OpinionatedGeek Ltd.  Software distributed
// under the License is distributed "as is" and without any warranty
// as to merchantability or fitness for a particular purpose or any
// other warranties either expressed or implied.  The author will
// not be liable for data loss, damages, loss of profits or any
// other kind of loss while using or misusing this software.
//
// For more information visit http://www.opinionatedgeek.com/
//
//====================================================================
//
//  File name:		$RCSfile$
//
//  VSS File:		$Source$
//
//  Last Modified:	$Date$
//
//  Author:			$Author$
//
//  Version:		$Revision$
//
//====================================================================

namespace OpinionatedGeek.Applications.ConnTest
{
	using System;
	using System.Collections;
	using System.Data;
	using System.Data.OleDb;
	using System.Data.SqlClient;
	using System.Diagnostics;
	using System.Drawing;
	using System.ComponentModel;
	using System.Windows.Forms;

	/// <summary>
	/// A really simple DB connection tester.
	/// </summary>
	public class ConnTest : System.Windows.Forms.Form
	{
		//====================================================================
		// Internal data
		//====================================================================

		private System.Windows.Forms.TextBox tbConnectionString;
		private System.Windows.Forms.Button butTestAction;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbUseSqlClient;
		private System.Windows.Forms.RadioButton rbUseOleDb;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		//====================================================================
		// Constructors
		//====================================================================

		public ConnTest
		(
		)
		{
			InitializeComponent();

			return;
		}

		//====================================================================
		// Properties
		//====================================================================

		//====================================================================
		// Methods
		//====================================================================

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose
		(
			bool disposing
		)
		{
			if (disposing)
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}

			base.Dispose (disposing);

			return;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ConnTest));
			this.tbConnectionString = new System.Windows.Forms.TextBox();
			this.butTestAction = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rbUseSqlClient = new System.Windows.Forms.RadioButton();
			this.rbUseOleDb = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// tbConnectionString
			// 
			this.tbConnectionString.Location = new System.Drawing.Point(152, 24);
			this.tbConnectionString.Multiline = true;
			this.tbConnectionString.Name = "tbConnectionString";
			this.tbConnectionString.Size = new System.Drawing.Size(392, 56);
			this.tbConnectionString.TabIndex = 0;
			this.tbConnectionString.Text = "<Connection String>";
			// 
			// butTestAction
			// 
			this.butTestAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.butTestAction.Location = new System.Drawing.Point(400, 96);
			this.butTestAction.Name = "butTestAction";
			this.butTestAction.Size = new System.Drawing.Size(144, 23);
			this.butTestAction.TabIndex = 1;
			this.butTestAction.Text = "Test Connection!";
			this.butTestAction.Click += new System.EventHandler(this.butTestAction_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 192);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(152, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter the database connection string to test:";
			// 
			// rbUseSqlClient
			// 
			this.rbUseSqlClient.Checked = true;
			this.rbUseSqlClient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbUseSqlClient.Location = new System.Drawing.Point(152, 88);
			this.rbUseSqlClient.Name = "rbUseSqlClient";
			this.rbUseSqlClient.Size = new System.Drawing.Size(160, 24);
			this.rbUseSqlClient.TabIndex = 4;
			this.rbUseSqlClient.TabStop = true;
			this.rbUseSqlClient.Text = "Use SqlClient connection";
			// 
			// rbUseOleDb
			// 
			this.rbUseOleDb.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbUseOleDb.Location = new System.Drawing.Point(152, 112);
			this.rbUseOleDb.Name = "rbUseOleDb";
			this.rbUseOleDb.Size = new System.Drawing.Size(160, 24);
			this.rbUseOleDb.TabIndex = 5;
			this.rbUseOleDb.Text = "Use OleDb connection";
			// 
			// ConnTest
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 205);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.rbUseOleDb,
																		  this.rbUseSqlClient,
																		  this.label1,
																		  this.pictureBox1,
																		  this.butTestAction,
																		  this.tbConnectionString});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConnTest";
			this.Text = "Opinionated Geek Database Connection Tester v1.1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the connection tester.
		/// </summary>
		[STAThread]
		static void Main
		(
		) 
		{
			Application.Run (new ConnTest());

			return;
		}

		private void butTestAction_Click
		(
			object sender,
			System.EventArgs e
		)
		{
			butTestAction.Enabled = false;

			bool nSuccessful = false;
			Exception exStoredException = null;
			try
			{
				IDbConnection idbConn = GetConnection (tbConnectionString.Text);
				idbConn.Open ();
				nSuccessful = true;
			}
			catch (Exception ex)
			{
				exStoredException = ex;
			}

			string szMessage;
			if (nSuccessful)
			{
				szMessage = "Connection successful!";
			}
			else
			{
				szMessage = "Connection failed: " + exStoredException.Message + ".";
			}

			MessageBox.Show (szMessage);

			butTestAction.Enabled = true;
			return;
		}

		private void pictureBox1_Click
		(
			object sender,
			System.EventArgs e
		)
		{
			Process.Start ("http://www.opinionatedgeek.com/");

			return;
		}

		private IDbConnection GetConnection
		(
			string szConnectionString
		)
		{
			IDbConnection idbConn;
			if (rbUseSqlClient.Checked)
			{
				idbConn = new SqlConnection (szConnectionString);
			}
			else
			{
				idbConn = new OleDbConnection (szConnectionString);
			}

			return idbConn;
		}
	}
}
