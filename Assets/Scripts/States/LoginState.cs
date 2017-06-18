using System.Collections.Generic;
using UnityEngine;
using CaomaoFramework;

public class LoginState : ClientStateBase
{
    public override void OnEnter()
    {
        EventDispatch.Broadcast("DlgLogin");
    }
    public override void OnLeave()
    {
        
    }
}
