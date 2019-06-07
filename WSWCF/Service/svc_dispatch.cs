using Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class svc_Dispatch : i_dispatching
    {

        private MSG msg;
        private svc_Calcul calcul;
        private int response;

        public svc_Dispatch()
        {
            this.msg = new MSG();
            this.calcul = new svc_Calcul();
        }


        public MSG dispatching(MSG msg)
        {
            if (msg.app_token == "itsgood")
            {
                switch (msg.op_name)
                {
                    case "add":
                        this.response = this.calcul.m_add((int)msg.data_table[0], (int)msg.data_table[1]);
                        this.msg.data_table = new object[1] { (object)response };
                        break;
                    case "sous":
                        this.response = this.calcul.m_sous((int)msg.data_table[0], (int)msg.data_table[1]);
                        this.msg.data_table = new object[1] { (object)response };
                        break;
                    case "mul":
                        this.response = this.calcul.m_mul((int)msg.data_table[0], (int)msg.data_table[1]);
                        this.msg.data_table = new object[1] { (object)response };
                        break;
                }
                this.msg.op_infos = "Operation ok";
                this.msg.op_statut = true;
            }
            else
            {
                this.msg.op_infos = "Operation aborted";
                this.msg.op_statut = false;
            }
            this.msg.app_name = null;
            this.msg.app_token = null;
            this.msg.app_version = null;
            this.msg.user_login = null;
            this.msg.user_password = null;
            this.msg.user_token = null;
            return this.msg;
        }
    }
}
