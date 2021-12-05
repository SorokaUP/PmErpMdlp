namespace PMMarkingUI.Views
{
    partial class DocumentMap
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentMap));
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "arrow_right.png");
            this.imgIcons.Images.SetKeyName(1, "arrow_right_down.png");
            this.imgIcons.Images.SetKeyName(2, "wait_for.png");
            this.imgIcons.Images.SetKeyName(3, "finish.png");
            // 
            // DocumentMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DocumentMap";
            this.Size = new System.Drawing.Size(752, 155);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgIcons;
    }
}
