Going into this:
 - loose understanding of mandebrot set
   - (initial understanding) colour of each point is computed by how quickly, if ever, the sequence a(n+1) = a(n)^2 + c with a(0) = 0 diverges after 200 iterations. 
 - no understanding of compute shaders

Aims:
 - make pretty mafs art
 - learn how to create a shader to compute the madelbrot set with HLSL

General Plan:
- iterate over each pixel and 
   - apply sequence function up to N times
   - if its absoloute value exceeds 200 (i think thats the number after which the sequence diverges absoloutely) then
      - escape point = n
   - if doesnt after N times
      - escape point = N
- return colour for each pixel based on escape point, if N then black.
- badabing badaboom.