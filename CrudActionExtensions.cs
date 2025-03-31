using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
	public class CrudActionExtensions : IContainer {
		public ComponentCollection Components => throw new NotImplementedException();

		public void Add(IComponent? component) {
			throw new NotImplementedException();
		}

		public void Add(IComponent? component, string? name) {
			throw new NotImplementedException();
		}

		public void Dispose() {
			throw new NotImplementedException();
		}

		public void Remove(IComponent? component) {
			throw new NotImplementedException();
		}
	}
}
