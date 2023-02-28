// CSUniverse, a solver interface.
// Copyright (c) 2022 - Univ Artois, CNRS & Exakis Nelite.
// All rights reserved.
//
// This library is free software, you can redistribute it and/or.
// modify it under the terms of the GNU Lesser General Public.
// License as published by the Free Software Foundation, eithe.
// version 3 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful.
// but WITHOUT ANY WARRANTY without even the implied warranty o.
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public.
// License along with this library.
// If not, see {@link http://www.gnu.org/licenses}.
//

namespace Fr.UnivArtois.CRIL.CSUniverse.Csp
{
    ///<summary>
    /// The UniverseTransition
    ///
    ///
    ///</summary>
    public class UniverseTransition
    {
        ///<summary>
        /// The source state, where the transition begins.
        ///</summary>
        private string start;

        ///<summary>
        /// The value (object) labeling the transition.
        ///</summary>
        private int value;

        ///<summary>
        /// The target state, where the transition ends.
        ///</summary>
        private string end;

        ///<summary>
        /// Creates a new UniverseTransition.
        ///</summary>
        ///<param name="start"></param>
        ///<param name="value"></param>
        ///<param name="end"></param>
        public UniverseTransition(string start, int value, string end)
        {
            this.start = start;
            this.value = value;
            this.end = end;
        }


        ///<summary>
        /// Gives the start of this UniverseTransition.
        ///
        ///<return>UniverseTransition's start.</return>
        ///</summary>
        public string GetStart()
        {
            return start;
        }


        ///<summary>
        /// Gives the value of this UniverseTransition.
        ///
        ///<return>UniverseTransition's value.</return>
        ///</summary>
        public int GetValue()
        {
            return value;
        }


        ///<summary>
        /// Gives the end of this UniverseTransition.
        ///
        ///<return>UniverseTransition's end.</return>
        ///</summary>
        public string GetEnd()
        {
            return end;
        }


    }

}
