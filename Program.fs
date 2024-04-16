open TriangleNet

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let mesher = Meshing.GenericMesher()
let res = mesher.Triangulate(ResizeArray [Geometry.Vertex(1.0,2.0); Geometry.Vertex(1.2,2.3); Geometry.Vertex(-5.0,2.4); Geometry.Vertex(2.88,-9.2)])
res.Triangles |> Seq.iter (printfn "%A")