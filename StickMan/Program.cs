using StickManApp;

var stickManA = new StickMan(3, 3, true, false);
var stickManB = new StickMan(10, 10, false, true);
while (true)
{
    Console.Clear();
    stickManA.Draw();
    stickManB.Draw();
    Thread.Sleep(300);
    stickManA.Swap();
    stickManA.MoveRight();
    stickManB.Swap();
}


/*
 O/
/|
/ \
*/   
   