﻿namespace Trello.Net
{
  public class CloseCardAction : Action
  {
    public CloseCardAction()
    {
      Data = new ActionData();
    }

    public ActionData Data { get; set; }

    public class ActionData : IUpdateData
    {
      public BoardName Board { get; set; }
      public CardName Card { get; set; }

      public Old Old { get; set; }
    }

    public class CardName : Trello.Net.CardName
    {
      public bool Closed { get; set; }
    }
  }
}