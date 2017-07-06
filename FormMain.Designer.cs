namespace HtmlDocumentCreator
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.buttonCreate = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(292, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "This is a sample Windows Application sample";
      // 
      // buttonCreate
      // 
      this.buttonCreate.Location = new System.Drawing.Point(39, 85);
      this.buttonCreate.Name = "buttonCreate";
      this.buttonCreate.Size = new System.Drawing.Size(75, 23);
      this.buttonCreate.TabIndex = 1;
      this.buttonCreate.Text = "Create";
      this.buttonCreate.UseVisualStyleBackColor = true;
      this.buttonCreate.Click += new System.EventHandler(this.ButtonCreateClick);
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(181, 85);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 2;
      this.buttonSave.Text = "Save";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
      // 
      // webBrowser1
      // 
      this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowser1.Location = new System.Drawing.Point(16, 137);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(920, 461);
      this.webBrowser1.TabIndex = 3;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(960, 629);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.buttonCreate);
      this.Controls.Add(this.label1);
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Html Document Creator";
      this.Load += new System.EventHandler(this.FormMainLoad);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonCreate;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.WebBrowser webBrowser1;
  }
}

