﻿namespace Game
{
    public class Controller
    {
        public Controller(View view, Model model)
        {
            view.MoveAction += model.moveAction;
            view.WallAction += model.placeWall;
            model.WinAction += view.showResult;
            model.Redraw += view.redraw;
            model.StenkaGorizont += view.StenkaGorizont;
            model.StenkaVertik += view.StenkaVertik;
        }
    }
}
