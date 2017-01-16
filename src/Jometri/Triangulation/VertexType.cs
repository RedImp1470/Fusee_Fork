﻿namespace Fusee.Jometri.Triangulation
{
    /// <summary>
    /// To partition a polygon into y monotone pieces the vertices of this polygon have to be distinguished into different types.
    /// Those are start, end, split, merge, and regular vertices.
    /// </summary>
    public enum VertexType
    {
        /// <summary>
        /// A vertex is a start veretx in case his two neighbours are below him and the interior angle between the two adjacent edges is smaller than pi.
        /// </summary>
        START_VERTEX,

        /// <summary>
        /// A vertex is a end veretx in case his two neighbours are above him and the interior angle between the two adjacent edges is smaller than pi.
        /// </summary>
        END_VERTEX,

        /// <summary>
        /// A vertex is a split veretx in case his two neighbours are below him and the interior angle between the two adjacent edges is grater than pi.
        /// </summary>
        SPLIT_VERTEX,

        /// <summary>
        /// A vertex is a merge veretx in case his two neighbours are above him and the interior angle between the two adjacent edges is grater than pi.
        /// </summary>
        MERGE_VERTEX,

        /// <summary>
        /// A vertex is a regular veretx in case his two neighbours and the adjacent edges do not meet one of the conditions defining the other types.
        /// </summary>
        REGULAR_VERTEX
    }
}
