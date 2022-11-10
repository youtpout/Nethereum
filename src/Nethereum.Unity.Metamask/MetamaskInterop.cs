﻿using System;
using System.Runtime.InteropServices;

namespace Nethereum.Unity.Metamask
{

    public class MetamaskInterop
    {
        [DllImport("__Internal")]
        public static extern string EnableEthereum(string gameObjectName, string callback, string fallback);

        [DllImport("__Internal")]
        public static extern void EthereumInit(string gameObjectName, string callBackAccountChange, string callBackChainChange);

        [DllImport("__Internal")]
        public static extern void GetChainId(string gameObjectName, string callback, string fallback);

        [DllImport("__Internal")]
        public static extern bool IsMetamaskAvailable();

        [DllImport("__Internal")]
        public static extern string GetSelectedAddress();

        [DllImport("__Internal")]
        public static extern string Request(string rpcRequestMessage, string gameObjectName, string callback, string fallback);

        [DllImport("__Internal")]
        public static extern string RequestRpcClientCallback(Action<string> rpcResponse, string rpcRequest);

        [DllImport("__Internal")]
        public static extern void AddEthereumChain(string chainParameter);

        [DllImport("__Internal")]
        public static extern void SwitchEthereumChain(string chainId);

        [DllImport("__Internal")]
        public static extern bool IsConnected();

    }

}
