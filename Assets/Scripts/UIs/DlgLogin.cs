using System;
using System.Collections.Generic;
using UnityEngine;
using CaomaoFramework;
[Serializable]
public class DlgLogin : UIBase
{
    public DlgLogin()
    {
        this.mResName = "Prefabs/Guis/DlgLogin";
        this.mResident = false;
    }
    public override void Init()
    {
        EventDispatch.AddListener("DlgLogin", this.Show);
    }

    public override void OnDisable()
    {
        
    }

    public override void OnEnable()
    {
        
    }

    public override void Realse()
    {
        EventDispatch.RemoveListener("DlgLogin", this.Show);
    }

    protected override void InitWidget()
    {
    }

    protected override void OnAddListener()
    {
        
    }

    protected override void OnRemoveListener()
    {
        
    }

    protected override void RealseWidget()
    {
       
    }
}