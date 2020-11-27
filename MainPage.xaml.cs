﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDM_TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //btn1.Clicked += onClick;
        }

        void onClickOk(object sender, EventArgs args)
        {
            print("[INFO] função onClickOk\n");
            if (user.Text.Contains("@") && user.Text.Contains(".com"))
            {
                print("[INFO]" + user.Text  + " logado com sucesso!");
            }
            else {
                print("[ERRO] identificador inválido\n");
            }
        }
        void onClickLimpar(object sender, EventArgs args)
        {
            print("[INFO] função onClickLimpar\n");
            user.Text = "";
            pass.Text = "";
            consoleLog.Text = "";
        }
        void onClickCreditos(object sender, EventArgs args)
        {
            print("[INFO] onClickCreditos\n");
            print("Criado por: Lucas D'Antônio CB-300161X e Gabriel Brito - CB3002373\n");
        }

        void print(String message) {
            consoleLog.Text += message;
        }

    }
}
