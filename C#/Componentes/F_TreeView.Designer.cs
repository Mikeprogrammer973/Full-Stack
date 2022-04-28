
namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Livros da Lei");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Livros de Histórias");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Livros de Profecias");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Livros de Poesia e Cantos");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Antigo Testamento", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mateus");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Marcos");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Lucas");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("João");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Evangelhos", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Epístolas");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Novo Testamento", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Bíiblia Sagrada", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("La Marque d\'Athena");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Le Fils de Neptune");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Le Sang de l\'Olympe");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("La Maison d\'Hadès");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Héros de l\'Olympe", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("São Paulo");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Cidade Nova");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("São Vicente");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Corderros");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Itajaí", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Joinville");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Navegantes");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Santa Catarina", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Estados", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Azul");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Laranja");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Cores", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.tb_selected = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "lei";
            treeNode1.Text = "Livros da Lei";
            treeNode2.Name = "historias";
            treeNode2.Text = "Livros de Histórias";
            treeNode3.Name = "profecias";
            treeNode3.Text = "Livros de Profecias";
            treeNode4.Name = "poesia_canto";
            treeNode4.Text = "Livros de Poesia e Cantos";
            treeNode5.Name = "antigo";
            treeNode5.Text = "Antigo Testamento";
            treeNode6.Name = "mateus";
            treeNode6.Text = "Mateus";
            treeNode7.Name = "marcos";
            treeNode7.Text = "Marcos";
            treeNode8.Name = "lucas";
            treeNode8.Text = "Lucas";
            treeNode9.Name = "joao";
            treeNode9.Text = "João";
            treeNode10.Name = "evangelhos";
            treeNode10.Text = "Evangelhos";
            treeNode11.Name = "espistolas";
            treeNode11.Text = "Epístolas";
            treeNode12.Name = "novo";
            treeNode12.Text = "Novo Testamento";
            treeNode13.Name = "bible";
            treeNode13.Tag = "https://mikeprogrammer973.github.io/daily_verses/";
            treeNode13.Text = "Bíiblia Sagrada";
            treeNode14.Name = "athena";
            treeNode14.Text = "La Marque d\'Athena";
            treeNode15.Name = "neptune";
            treeNode15.Text = "Le Fils de Neptune";
            treeNode16.Name = "olympe";
            treeNode16.Text = "Le Sang de l\'Olympe";
            treeNode17.Name = "hades";
            treeNode17.Text = "La Maison d\'Hadès";
            treeNode18.Name = "heros_olympe";
            treeNode18.Text = "Héros de l\'Olympe";
            treeNode19.Name = "sao_paulo";
            treeNode19.Text = "São Paulo";
            treeNode20.Name = "cidade_nova";
            treeNode20.Text = "Cidade Nova";
            treeNode21.Name = "sao_vicente";
            treeNode21.Text = "São Vicente";
            treeNode22.Name = "corderros";
            treeNode22.Text = "Corderros";
            treeNode23.Name = "itajai";
            treeNode23.Text = "Itajaí";
            treeNode24.Name = "joinville";
            treeNode24.Text = "Joinville";
            treeNode25.Name = "navegantes";
            treeNode25.Text = "Navegantes";
            treeNode26.Name = "santa_catarina";
            treeNode26.Text = "Santa Catarina";
            treeNode27.Name = "estados";
            treeNode27.Text = "Estados";
            treeNode28.Name = "azul";
            treeNode28.Text = "Azul";
            treeNode29.Name = "laranja";
            treeNode29.Text = "Laranja";
            treeNode30.Name = "cores";
            treeNode30.Text = "Cores";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode18,
            treeNode27,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(261, 336);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(280, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(132, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(280, 42);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(132, 23);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // tb_selected
            // 
            this.tb_selected.Location = new System.Drawing.Point(280, 71);
            this.tb_selected.Name = "tb_selected";
            this.tb_selected.Size = new System.Drawing.Size(132, 20);
            this.tb_selected.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 4;
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_selected);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox tb_selected;
        private System.Windows.Forms.TextBox textBox1;
    }
}