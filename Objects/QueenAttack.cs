namespace QueenAttack
{
  public class Queen
  {
    public bool CanAttack(int queenX, int queenY, int attackPositionX, int attackPositionY)
    {
      int xDiff = queenX - attackPositionX;
      int yDiff = queenY - attackPositionY;
      if(queenY == attackPositionY)
      {
        return true;
      }
      else if(queenX == attackPositionX)
      {
        return true;
      }
      else if(xDiff == yDiff)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
