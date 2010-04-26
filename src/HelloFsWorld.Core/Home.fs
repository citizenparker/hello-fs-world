module Home
  
  open Bistro.FS.Definitions
  open Bistro.FS.Inference
    
  open Bistro.Controllers.Descriptor
  open Bistro.Controllers.Descriptor.Data

  [<Bind("")>]
  [<RenderWith("Views/home.django")>]
  [<ReflectedDefinition>]
  let home (ctx : ictx) =
    "Hello, my F# World!" |> named "message"