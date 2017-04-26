# Questions?
  For the older version of this code, or to use the primitive tools, please see "Primitive Documentation" document.
  
# Purpose:
  This code generates terrain in Unity in chunks. These chunks are instantiated based on the viewer distance, so the further the viewer is 
  (current view distance is 30 meters) the more spawn. The viewer will move, disabling older chunks 30+ meters out, and enabling the new
  chunks which are in range. This continues. The chunks have higher poly near the viewer, and every 10 meters from the viewer they lower the
  poly.
