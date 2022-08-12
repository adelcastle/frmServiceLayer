
namespace Form_ServiceLayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.txtCredenciales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gvLista = new System.Windows.Forms.DataGridView();
            this.cmdClientes = new System.Windows.Forms.Button();
            this.cmdVerCliente2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtJsonOrder = new System.Windows.Forms.TextBox();
            this.cmdOrdenVenta = new System.Windows.Forms.Button();
            this.txtCrearOrder = new System.Windows.Forms.TextBox();
            this.txtOrderResult = new System.Windows.Forms.TextBox();
            this.cmdCrear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(103, 22);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(473, 20);
            this.txturl.TabIndex = 1;
            this.txturl.Text = "https://localhost:50000/b1s/v1";
            // 
            // txtCredenciales
            // 
            this.txtCredenciales.Location = new System.Drawing.Point(103, 48);
            this.txtCredenciales.Name = "txtCredenciales";
            this.txtCredenciales.Size = new System.Drawing.Size(473, 20);
            this.txtCredenciales.TabIndex = 2;
            this.txtCredenciales.Text = "{\"CompanyDB\":\"SBODEMOGT\",\"Password\":\"manager\",\"UserName\":\"manager\"}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conexion:";
            // 
            // txtSessionId
            // 
            this.txtSessionId.Location = new System.Drawing.Point(12, 103);
            this.txtSessionId.Multiline = true;
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(257, 64);
            this.txtSessionId.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(284, 103);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(317, 64);
            this.txtResult.TabIndex = 7;
            this.txtResult.Text = resources.GetString("txtResult.Text");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Login2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvLista
            // 
            this.gvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLista.Location = new System.Drawing.Point(12, 173);
            this.gvLista.Name = "gvLista";
            this.gvLista.Size = new System.Drawing.Size(589, 244);
            this.gvLista.TabIndex = 9;
            // 
            // cmdClientes
            // 
            this.cmdClientes.Location = new System.Drawing.Point(170, 74);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(75, 23);
            this.cmdClientes.TabIndex = 10;
            this.cmdClientes.Text = "Ver Clientes";
            this.cmdClientes.UseVisualStyleBackColor = true;
            this.cmdClientes.Click += new System.EventHandler(this.cmdClientes_Click);
            // 
            // cmdVerCliente2
            // 
            this.cmdVerCliente2.Location = new System.Drawing.Point(248, 74);
            this.cmdVerCliente2.Name = "cmdVerCliente2";
            this.cmdVerCliente2.Size = new System.Drawing.Size(82, 23);
            this.cmdVerCliente2.TabIndex = 11;
            this.cmdVerCliente2.Text = "Ver Clientes2";
            this.cmdVerCliente2.UseVisualStyleBackColor = true;
            this.cmdVerCliente2.Click += new System.EventHandler(this.cmdVerCliente2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "json a datatable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(420, 74);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 13;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Add Cliente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtJsonOrder
            // 
            this.txtJsonOrder.Location = new System.Drawing.Point(607, 76);
            this.txtJsonOrder.Multiline = true;
            this.txtJsonOrder.Name = "txtJsonOrder";
            this.txtJsonOrder.Size = new System.Drawing.Size(200, 341);
            this.txtJsonOrder.TabIndex = 15;
            this.txtJsonOrder.Text = resources.GetString("txtJsonOrder.Text");
            // 
            // cmdOrdenVenta
            // 
            this.cmdOrdenVenta.Location = new System.Drawing.Point(689, 45);
            this.cmdOrdenVenta.Name = "cmdOrdenVenta";
            this.cmdOrdenVenta.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdenVenta.TabIndex = 16;
            this.cmdOrdenVenta.Text = "Crear OrdenVenta";
            this.cmdOrdenVenta.UseVisualStyleBackColor = true;
            this.cmdOrdenVenta.Click += new System.EventHandler(this.cmdOrdenVenta_Click);
            // 
            // txtCrearOrder
            // 
            this.txtCrearOrder.Location = new System.Drawing.Point(689, 12);
            this.txtCrearOrder.Name = "txtCrearOrder";
            this.txtCrearOrder.Size = new System.Drawing.Size(281, 20);
            this.txtCrearOrder.TabIndex = 17;
            this.txtCrearOrder.Text = "https://localhost:50000/b1s/v1/Orders";
            // 
            // txtOrderResult
            // 
            this.txtOrderResult.Location = new System.Drawing.Point(813, 76);
            this.txtOrderResult.Multiline = true;
            this.txtOrderResult.Name = "txtOrderResult";
            this.txtOrderResult.Size = new System.Drawing.Size(200, 341);
            this.txtOrderResult.TabIndex = 18;
            // 
            // cmdCrear2
            // 
            this.cmdCrear2.Location = new System.Drawing.Point(779, 45);
            this.cmdCrear2.Name = "cmdCrear2";
            this.cmdCrear2.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear2.TabIndex = 19;
            this.cmdCrear2.Text = "Crear OrdenVenta";
            this.cmdCrear2.UseVisualStyleBackColor = true;
            this.cmdCrear2.Click += new System.EventHandler(this.cmdCrear2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 458);
            this.Controls.Add(this.cmdCrear2);
            this.Controls.Add(this.txtOrderResult);
            this.Controls.Add(this.txtCrearOrder);
            this.Controls.Add(this.cmdOrdenVenta);
            this.Controls.Add(this.txtJsonOrder);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdVerCliente2);
            this.Controls.Add(this.cmdClientes);
            this.Controls.Add(this.gvLista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSessionId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCredenciales);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtCredenciales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvLista;
        private System.Windows.Forms.Button cmdClientes;
        private System.Windows.Forms.Button cmdVerCliente2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtJsonOrder;
        private System.Windows.Forms.Button cmdOrdenVenta;
        private System.Windows.Forms.TextBox txtCrearOrder;
        private System.Windows.Forms.TextBox txtOrderResult;
        private System.Windows.Forms.Button cmdCrear2;
    }
}

