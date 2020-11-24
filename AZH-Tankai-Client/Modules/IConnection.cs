using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace AZH_Tankai_Client.Modules
{
    interface IConnection
    {
        public void ReceivePlayer();
        public void ReceiveMaze();
        public void ReceiveCoordinate();
        public void ReceiveBulletCoordinates();
        public void PlayerExists();
        public void TerminatePlayer();
    }
}
