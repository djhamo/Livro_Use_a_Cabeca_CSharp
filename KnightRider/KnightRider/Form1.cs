using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KnightRider
{
    enum MyStatusForm
    {
        PasseioInterativo,
        PasseioTurbo,
        Pausado,
        Completado_Parado_Cancelado,
    }
    public partial class Form1 : Form
    {
        Jogador jog;
        Renderer render;

        private TabForm tabForm;
        private MyStatusForm mStatus;
        public Form1()
        {
            mStatus = MyStatusForm.Completado_Parado_Cancelado;

            InitializeComponent();
            UpdateForm();
           
        }

        public void UpdateForm()
        {
            switch (mStatus)
            {
                case MyStatusForm.PasseioInterativo: 
                    {
                        txAltura.Enabled = false;
                        txLargura.Enabled = false;
                        txPosX.Enabled = false;
                        txPosY.Enabled = false;
                        ckTodasSolucoes.Enabled = false;

                        toolStrip1.Items[0].Text = "Pause";
                        toolStrip1.Items[2].Enabled = false;
                        break;
                    }
                case MyStatusForm.PasseioTurbo:
                    {
                        txAltura.Enabled = false;
                        txLargura.Enabled = false;
                        txPosX.Enabled = false;
                        txPosY.Enabled = false;
                        ckTodasSolucoes.Enabled = false;
                        //Não pausa ainda, passei pro inferno
                        toolStrip1.Items[0].Enabled = false;
                        toolStrip1.Items[1].Enabled = false;
                        toolStrip1.Items[2].Enabled = false;
                        break;
                    }
                case MyStatusForm.Pausado:
                    {
                        txAltura.Enabled = false;
                        txLargura.Enabled = false;
                        txPosX.Enabled = false;
                        txPosY.Enabled = false;
                        ckTodasSolucoes.Enabled = false;
                        toolStrip1.Items[0].Text = "Resume";
                        toolStrip1.Items[2].Enabled = false;
                        break;
                    }
                case MyStatusForm.Completado_Parado_Cancelado:
                    {

                        toolStrip1.Items[0].Text = "Start";
                        txAltura.Enabled = true;
                        txLargura.Enabled = true;
                        txPosX.Enabled = true;
                        txPosY.Enabled = true;
                        ckTodasSolucoes.Enabled = true;
                        toolStrip1.Items[0].Enabled = true;
                        toolStrip1.Items[1].Enabled = true;
                        toolStrip1.Items[2].Enabled = true;
                        if (tabForm != null)
                            tabForm.Close();
                        break;
                    }
            }
        }
        private void numVelocidade_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numVelocidade.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jog.Jogar();
            tabForm.Invalidate();
            if (jog.mStatus == PlayerStatus.Finalizado)
            {
                tFim(true);
            }
            
        }

        private void lbStart_Click(object sender, EventArgs e)
        {
            if (mStatus == MyStatusForm.Completado_Parado_Cancelado)
            {
                int larg, alt, px, py;

                int tempInt;
                if (int.TryParse(txLargura.Text, out tempInt))
                    larg = tempInt;
                else
                    throw new ArgumentNullException();

                if (int.TryParse(txAltura.Text, out tempInt))
                    alt = tempInt;
                else
                    throw new ArgumentNullException();

                if (int.TryParse(txPosX.Text, out tempInt))
                    px = tempInt;
                else
                    throw new ArgumentNullException();

                if (int.TryParse(txPosY.Text, out tempInt))
                    py = tempInt;
                else
                    throw new ArgumentNullException();

                if ((px >= alt) || (py >= larg))
                {
                    MessageBox.Show("Posição Inicial fora do Tabuleiro", "Erro Knight Rider",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return ;
                }

                jog = InitializeJogador();

                tabForm = new TabForm();
                render = new Renderer(jog, tabForm);
                tabForm.Show(this);


                jog.Start();
                timer1.Start();

                mStatus = MyStatusForm.PasseioInterativo;
                MoveChildForms();
                UpdateForm();
            }
            else
            {
                if (mStatus == MyStatusForm.PasseioInterativo)
                {
                    timer1.Stop();
                    mStatus = MyStatusForm.Pausado;
                }
                else
                {
                    timer1.Start();
                    mStatus = MyStatusForm.PasseioInterativo;
                }

            }
            UpdateForm();
        }

        private void lbReset_Click(object sender, EventArgs e)
        {
            jog.Reset();
            mStatus = MyStatusForm.Completado_Parado_Cancelado;
            if (timer1.Enabled)
                timer1.Stop();
            UpdateForm();
        }

        public Jogador InitializeJogador()
        {
            Jogador jogador;

            int larg, alt, px, py;

            int tempInt;
            if (int.TryParse(txLargura.Text, out tempInt))
                larg = tempInt;
            else
                throw new ArgumentNullException();

            if (int.TryParse(txAltura.Text, out tempInt))
                alt = tempInt;
            else
                throw new ArgumentNullException();

            if (int.TryParse(txPosX.Text, out tempInt))
                px = tempInt;
            else
                throw new ArgumentNullException();

            if (int.TryParse(txPosY.Text, out tempInt))
                py = tempInt;
            else
                throw new ArgumentNullException();


            Point tPoint = new Point(px, py);
            jogador = new Jogador(larg, alt, tPoint, ckTodasSolucoes.Checked);
            jogador.StObserver = iStateMessage;
            jogador.MovementObserver = iMoveMessage;

            return jogador;
        }

        private void MoveChildForms()
        {
            if (mStatus != MyStatusForm.Completado_Parado_Cancelado 
                && mStatus != MyStatusForm.PasseioTurbo)
            {
                tabForm.Location = new Point(this.Location.X + this.Width + 10,
                    this.Location.Y);
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }

        private void iStateMessage(PlayerStatus status)
        {
            statusStrip1.Items[0].Text = status.ToString();
            if (jog.mStatus == PlayerStatus.Finalizado)
            {
                tFim(true);
            }
        }

        private void iMoveMessage(Point ini, Point dest, PlayerStatus status)
        {
            statusStrip1.Items[0].Text = "{" + ini.X.ToString() + ":" + ini.Y.ToString()
                + "} => {" + dest.X.ToString() + ":" + dest.Y.ToString() + "} = "
                + status.ToString();
        }



        private void tFim(bool victory)
        {
            if (timer1.Enabled)
                timer1.Stop();
            mStatus = MyStatusForm.Completado_Parado_Cancelado;
            UpdateForm();

            statusStrip1.Items[0].Text = "Respostas encontradas: " + jog.Respostas.Count;
        }


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            mStatus = MyStatusForm.PasseioTurbo;
            //render.ResizeTabuleiro(5, 5);

            Jogador jog2;
            jog2 = InitializeJogador();

            backgroundWorker1.RunWorkerAsync(jog2);

            UpdateForm();

        }


        private void abrirToolStripButton1_Click(object sender, EventArgs e)
        {

            Jogador currentJogador = jog;

            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();

            OpenFileDialog openDIalog = new OpenFileDialog();
            openDIalog.Filter = "Knight Simulator File (*.knight)|*.knight";
            openDIalog.CheckPathExists = true;
            openDIalog.CheckFileExists = true;
            openDIalog.Title = "Choose a file with a simulation to load";

            if (openDIalog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream input = File.OpenRead(openDIalog.FileName))
                    {
                        jog = (Jogador)bf.Deserialize(input);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read the simulation file\r\n"
                        + ex.Message, "Knight Simulator Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    jog = currentJogador;

                }
            }
            if (mStatus == MyStatusForm.Completado_Parado_Cancelado)
            {
                tabForm = new TabForm();
                render = new Renderer(jog, tabForm);
                tabForm.Show(this);
            }
            else
            {
                render.mJogador = jog;
                render.ResizeTabuleiro(jog.Largura, jog.Altura);
            }
            jog.StObserver = iStateMessage;
            jog.MovementObserver = iMoveMessage;

            jog.Start();

            if (enabled)
                mStatus = MyStatusForm.PasseioInterativo;
            else
                mStatus = MyStatusForm.Pausado;

            
            txLargura.Text = jog.Largura.ToString();
            txAltura.Text = jog.Altura.ToString();
            txPosX.Text = jog.posInicial.X.ToString();
            txPosY.Text = jog.posInicial.Y.ToString();
            ckTodasSolucoes.ThreeState = jog.TotalSolution;

            MoveChildForms();
            UpdateForm();

            if (enabled)
                timer1.Start();
        }

        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Knight Simulator File (*.knight)|*.knight";
            saveDialog.CheckPathExists = true;
            saveDialog.Title = "Choose a file to save the current simulation";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream output = File.OpenWrite(saveDialog.FileName))
                    {
                        bf.Serialize(output, jog);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save the simulator file\r\n"
                        + ex.Message, "Knight Simulator", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            if (enabled)
                timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Renderer render2 = new Renderer(jog2, tabForm2);
            Jogador jog2 = e.Argument as Jogador;

            jog2.StObserver = tStateMessage;
            jog2.MovementObserver = tMoveMessage;

            jog2.Start();


            while (jog2.mStatus != PlayerStatus.Finalizado)
            {
                jog2.Jogar();

                if (jog2.mStatus == PlayerStatus.CaminhoEncontrado)
                {
                    string item = string.Join(",", jog2.mCaminho.Keys.ToList());
                    backgroundWorker1.ReportProgress(0, item);
                }

                //
                if (backgroundWorker1.CancellationPending)
                {
                    mStatus = MyStatusForm.Completado_Parado_Cancelado;
                    break;
                }
            }
            mStatus = MyStatusForm.Completado_Parado_Cancelado;
            e.Result = jog2;       
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            listBox1.Items.Add(e.UserState.ToString());

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Jogador jog2 = e.Result as Jogador;
            UpdateForm();
        }

        private void tStateMessage(PlayerStatus status)
        {
            //Label temp = statusStrip1.;
            //SetControlPropertyValue(temp, "Text", status.ToString());

        }

        private void tMoveMessage(Point ini, Point dest, PlayerStatus status)
        {
            /*
            statusStrip1.Items[0].Text = "{" + ini.X.ToString() + ":" + ini.Y.ToString()
                + "} => {" + dest.X.ToString() + ":" + dest.Y.ToString() + "} = "
                + status.ToString();
             */
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

    }

}
