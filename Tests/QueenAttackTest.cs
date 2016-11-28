using Xunit;
using QueenAttack.Objects;

namespace QueenAttack
{
  public class QueenAttackTest
  {
    [Fact]
    public void QueenCanAttack_CanAttackRank_True()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanAttack(0,1,5,1));
    }
    [Fact]
    public void QueenCanAttack_CanAttackFile_True()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanAttack(1,1,1,6));
    }
    [Fact]
    public void QueenCanAttack_CanAttackDiagonal_True()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanAttack(1,1,3,3));
    }
    [Fact]
    public void QueenCanAttack_CanAttackOther_False()
    {
      Queen testQueen = new Queen();
      Assert.Equal(false, testQueen.CanAttack(1,1,3,2));
    }
  }
}
