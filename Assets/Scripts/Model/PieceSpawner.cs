using Tactile.TactileMatch3Challenge.Model;

namespace Model {

	public class PieceSpawner : IPieceSpawner {
		
		public int CreateBasicPiece() {
			return UnityEngine.Random.Range(0, 5);
		}
		
	}

}