namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            return (enemy.incoporial || enemy.flying || enemy.subterranian);
            
            //gebruik hier een || (OR)
			//je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            return (enemy.flying|| enemy.subterranian || enemy.incoporial || enemy.swimmer);
            //gebruik hier een || (OR)
			//je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
        }
    }
}