[<FunScript.JS>]
module App

open FunScript
open FunScript.TypeScript

// Allows writing jq?name for element access
let jq(selector : string) = Globals.Dollar.Invoke selector
let (?) jq name = jq("#" + name)

[<JS; JSEmit("log.info({0})")>]
let log_info (a) = failwith "never" |> ignore

[<JS; JSEmit("log.enableAll()")>]
let log_enable (b) = failwith "never" |> ignore

[<JS; JSEmit("alert({0})")>]
let hello (a) = failwith "never" |> ignore

[<JS; JSEmit("global.GranularApplication1.MainWindow.SetOnMightyButton1Click({0})")>]
let SetOnMightyButton1Click (a) = failwith "never" |> ignore

let main() = 
    log_enable ()
    log_info ( "application started" )
    SetOnMightyButton1Click(
        fun _ -> 
            log_info ( "button clicked" )
            hello( "Clicked!" ) :> obj
    )|> ignore
