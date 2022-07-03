using System.Collections.Generic;
using Tactile.TactileMatch3Challenge.Model;

namespace Model {

	public class ResolveResult {
		public readonly Dictionary<Piece, ChangeInfo> changes = new Dictionary<Piece, ChangeInfo>();
	}

}