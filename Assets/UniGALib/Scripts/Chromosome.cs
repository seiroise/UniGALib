using UnityEngine;
using System.Collections;

namespace UniGALib {

	/// <summary>
	/// 染色体
	/// </summary>
	public class Chromosome<T> {

		private T[] _genes;

		public Chromosome(int count) {
			_genes = new T[count];
		}
	}
}