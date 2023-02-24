using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste02
{
    public partial class ControleEstoque : Form
    {
        public ControleEstoque()
        {
            InitializeComponent();
        }

        private void button_addAb_Click(object sender, EventArgs e)                                                                                                                //Botão Adicionar - Equipamentos
        {
            var confirmaA = true;

            string[] valorA = new string[3];

            string[] valorH = new string[2];

            valorA[0] = textBox_NomeA.Text;
            valorA[1] = textBox_NSerieA.Text;
            valorA[2] = textBox_FabricanteA.Text;

            valorH[0] = textBox_ValorA.Text;
            valorH[1] = maskTextBox_DataFabricacaoA.Text;

            for (var i = 0; i < valorA.Length; i++)
            {
                if (valorA[i] == "") { confirmaA = false; }
            }

            for (var i = 0; i < valorH.Length; i++)
            {
                if (valorH[i] == "") { confirmaA = false; }
            }

            if (!maskTextBox_DataFabricacaoA.MaskFull) { confirmaA = false; }

            if (!confirmaA) { label_AvisoA.Visible = true; } else { label_AvisoA.Visible = false; }

            if (textBox_NomeA.Text.Length < 6) { label_aviso.Visible = true; } else { label_aviso.Visible = false; }

            if (confirmaA && textBox_NomeA.Text.Length >= 6 && maskTextBox_DataFabricacaoA.MaskFull)
            {
                label_aviso.Visible = false;
                label_AvisoA.Visible = false;

                ListViewItem itemA;
                itemA = new ListViewItem(valorA);
                listView_Equip.Items.Add(itemA);

                itemA = new ListViewItem(valorH);
                listView_EquipHide.Items.Add(itemA);

                valorA[0] = "";
                valorA[1] = "";
                valorA[2] = "";

                valorH[0] = "";
                valorH[1] = "";

                textBox_NomeA.Text = "";
                textBox_NSerieA.Text = "";
                textBox_FabricanteA.Text = "";
                textBox_ValorA.Text = "";
                maskTextBox_DataFabricacaoA.Text = "";
            }
        }

        private void button_EditarA_Click(object sender, EventArgs e)                                                                                                              //Botão Editar - Equipamentos
        {
            var confirmaA = true;

            string[] valorA = new string[5];

            valorA[0] = textBox_NomeA.Text;
            valorA[1] = textBox_NSerieA.Text;
            valorA[2] = textBox_FabricanteA.Text;
            valorA[3] = textBox_ValorA.Text;
            valorA[4] = maskTextBox_DataFabricacaoA.Text;

            for (var i = 0; i < valorA.Length; i++)
            {
                if (valorA[i] == "") { confirmaA = false; }
            }

            if (!maskTextBox_DataFabricacaoA.MaskFull) { confirmaA = false; }

            if (!confirmaA) { label_AvisoA.Visible = true; } else { label_AvisoA.Visible = false; }

            if (textBox_NomeA.Text.Length < 6) { label_aviso.Visible = true; } else { label_aviso.Visible = false; }

            if (confirmaA && textBox_NomeA.Text.Length >= 6 && maskTextBox_DataFabricacaoA.MaskFull)
            {

                label_aviso.Visible = false;

                foreach (ListViewItem item in listView_Equip.Items)
                {
                    if (item.Selected)
                    {
                        item.SubItems[0].Text = valorA[0];
                        item.SubItems[1].Text = valorA[1];
                        item.SubItems[2].Text = valorA[2];

                        foreach (ListViewItem item1 in listView_EquipHide.Items)
                        {
                            listView_EquipHide.Items[item.Index].SubItems[0].Text = valorA[3];
                            listView_EquipHide.Items[item.Index].SubItems[1].Text = valorA[4];

                            valorA[0] = "";
                            valorA[1] = "";
                            valorA[2] = "";
                            valorA[3] = "";
                            valorA[4] = "";

                            textBox_NomeA.Text = "";
                            textBox_NSerieA.Text = "";
                            textBox_FabricanteA.Text = "";
                            textBox_ValorA.Text = "";
                            maskTextBox_DataFabricacaoA.Text = "";

                            return;
                        }
                    }
                }
            }
        }

        private void listView_Equip_SelectedIndexChanged_1(object sender, EventArgs e)                                                                                             //Selecionar item na ListView para Editar - Equipamentos
        {

            foreach (ListViewItem item in listView_Equip.Items)
            {
                if (item.Selected && !item.Checked)
                {
                    button_EditarA.Enabled = true;

                    textBox_NomeA.Text = item.SubItems[0].Text;
                    textBox_NSerieA.Text = item.SubItems[1].Text;
                    textBox_FabricanteA.Text = item.SubItems[2].Text;

                    foreach (ListViewItem item1 in listView_EquipHide.Items)
                    {
                        textBox_ValorA.Text = listView_EquipHide.Items[item.Index].SubItems[0].Text;
                        maskTextBox_DataFabricacaoA.Text = listView_EquipHide.Items[item.Index].SubItems[1].Text;
                    }
                    return;
                }
                else
                {
                    button_EditarA.Enabled = false;

                    textBox_NomeA.Text = "";
                    textBox_NSerieA.Text = "";
                    textBox_FabricanteA.Text = "";
                    textBox_ValorA.Text = "";
                    maskTextBox_DataFabricacaoA.Text = "";
                }
            }
        }

        private void button_ExcluirA_Click(object sender, EventArgs e)                                                                                                             //Botão Excluir - Equipamentos
        {
            button_aceitarA.Visible = true;
            button_cancelarAb.Visible = true;
            listView_Equip.CheckBoxes = true;
        }

        private void button_aceitar_Click(object sender, EventArgs e)                                                                                                              //SubBotão Excluir_aceitar - Equipamentos
        {
            foreach (ListViewItem item in listView_Equip.Items)
            {
                if (item.Checked)
                {
                    listView_EquipHide.Items.RemoveAt(item.Index);
                    listView_Equip.Items.RemoveAt(item.Index);
                    button_aceitarA.Visible = false;
                    button_cancelarAb.Visible = false;
                    listView_Equip.CheckBoxes = false;
                }
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)                                                                                                             //SubBotão Excluir_cancelar - Equipamentos
        {
            button_aceitarA.Visible = false;
            button_cancelarAb.Visible = false;
            listView_Equip.CheckBoxes = false;
        }

        private void button_CancelarA_Click(object sender, EventArgs e)                                                                                                            //Botão Cancelar/Limpar - Equipamentos
        {
            textBox_NomeA.Text = "";
            textBox_NSerieA.Text = "";
            textBox_FabricanteA.Text = "";
            textBox_ValorA.Text = "";
            maskTextBox_DataFabricacaoA.Text = "";
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void button_addB_Click(object sender, EventArgs e)                                                                                                                 //Botão Adicionar - Chamados
        {
            var confirmaB = true;

            string[] valorB = new string[4];

            valorB[0] = textBox_TituloBb.Text;
            valorB[1] = textBox_EquipB.Text;
            valorB[2] = masktextBox_DataAberBb.Text;
            valorB[3] = textBox_DescricaoB.Text;

            for (var i = 0; i < valorB.Length; i++)
            {
                if (valorB[i] == "") { confirmaB = false; }
            }

            if (!masktextBox_DataAberBb.MaskFull) { confirmaB = false; }

            if (!confirmaB) { label_AvisoB.Visible = true; } else { label_AvisoB.Visible = false; }

            if (confirmaB && masktextBox_DataAberBb.MaskCompleted)
            {
                ListViewItem itemB;
                itemB = new ListViewItem(valorB);
                listView_Chamados.Items.Add(itemB);

                valorB[0] = "";
                valorB[1] = "";
                valorB[2] = "";
                valorB[3] = "";

                textBox_TituloBb.Text = "";
                textBox_EquipB.Text = "";
                masktextBox_DataAberBb.Text = "";
                textBox_DescricaoB.Text = "";
            }
        }

        private void button_editarB_Click(object sender, EventArgs e)                                                                                                              //Botão Editar - Chamados
        {
            var confirmaB = true;

            string[] valorB = new string[4];

            valorB[0] = textBox_TituloBb.Text;
            valorB[1] = textBox_EquipB.Text;
            valorB[2] = masktextBox_DataAberBb.Text;
            valorB[3] = textBox_DescricaoB.Text;

            for (var i = 0; i < valorB.Length; i++)
            {
                if (valorB[i] == "") { confirmaB = false; }
            }

            if (!masktextBox_DataAberBb.MaskFull) { confirmaB = false; }

            if (!confirmaB) { label_AvisoB.Visible = true; } else { label_AvisoB.Visible = false; }

            if (confirmaB && masktextBox_DataAberBb.MaskCompleted)
            {
                foreach (ListViewItem item in listView_Chamados.Items)
                {
                    if (item.Selected)
                    {
                        item.SubItems[0].Text = valorB[0];
                        item.SubItems[1].Text = valorB[1];
                        item.SubItems[2].Text = valorB[2];
                        item.SubItems[3].Text = valorB[3];
                    }
                }

                valorB[0] = "";
                valorB[1] = "";
                valorB[2] = "";
                valorB[3] = "";

                textBox_TituloBb.Text = "";
                textBox_EquipB.Text = "";
                masktextBox_DataAberBb.Text = "";
                textBox_DescricaoB.Text = "";
            }
        }

        private void listView_Chamados_SelectedIndexChanged(object sender, EventArgs e)                                                                                            //Selecionar item na ListView para Editar - Chamados
        {

            foreach (ListViewItem item in listView_Chamados.Items)
            {
                if (item.Selected)
                {
                    button_EditarB.Enabled = true;

                    textBox_TituloBb.Text = item.SubItems[0].Text;
                    textBox_EquipB.Text = item.SubItems[1].Text;
                    masktextBox_DataAberBb.Text = item.SubItems[2].Text;
                    textBox_DescricaoB.Text = item.SubItems[3].Text;

                    return;
                }
                else
                {
                    button_EditarB.Enabled = false;

                    textBox_TituloBb.Text = "";
                    textBox_EquipB.Text = "";
                    masktextBox_DataAberBb.Text = "";
                    textBox_DescricaoB.Text = "";
                }
            }
        }

        private void button_ExcluirB_Click(object sender, EventArgs e)                                                                                                             //Botão Excluir - Chamados
        {
            button_aceitarB.Visible = true;
            button_cancelarBb.Visible = true;
            listView_Chamados.CheckBoxes = true;
        }

        private void button_aceitarB_Click(object sender, EventArgs e)                                                                                                             //SubBotão Excluir_aceitar - Chamados
        {
            foreach (ListViewItem item in listView_Chamados.Items)
            {
                if (item.Checked)
                {
                    listView_Chamados.Items.RemoveAt(item.Index);
                    button_aceitarB.Visible = false;
                    button_cancelarBb.Visible = false;
                    listView_Equip.CheckBoxes = false;
                }
            }
        }

        private void button_cancelarBb_Click(object sender, EventArgs e)                                                                                                           //SubBotão Excluir_cancelar - Chamados
        {
            button_aceitarB.Visible = false;
            button_cancelarBb.Visible = false;
            listView_Chamados.CheckBoxes = false;
        }

        private void button_CancelarB_Click(object sender, EventArgs e)                                                                                                            //Botão Cancelar/Limpar - Chamados
        {
            textBox_TituloBb.Text = "";
            textBox_EquipB.Text = "";
            masktextBox_DataAberBb.Text = "";
            textBox_DescricaoB.Text = "";
        }
    }
}
