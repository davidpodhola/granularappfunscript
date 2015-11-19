[<EntryPoint>]
let main argv = 
    use appComposeHomeJSFile = System.IO.File.CreateText(@"..\Output.Web\Index.html")

    fprintfn appComposeHomeJSFile """
<!DOCTYPE html>
<html lang="en-US">
<head>
    <meta charset="utf-8">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.4/jquery.js" type="text/javascript"></script>
    <script src="mscorlib.js" type="text/javascript"></script>
    <script src="linq.js" type="text/javascript"></script>
    <script src="Granular.Common.js" type="text/javascript"></script>
    <script src="Granular.Presentation.js" type="text/javascript"></script>
    <script src="Granular.Presentation.Generic.js" type="text/javascript"></script>
    <script src="Granular.Host.js" type="text/javascript"></script>
    <script src="GranularApplication1.js" type="text/javascript"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/loglevel/1.4.0/loglevel.min.js" type="text/javascript"></script>
</head>
<body>
    <script type="text/javascript">
        function ExclamationMark() { return "!" };
        (function () {
            'use strict';

            $(document).ready(function () {
                %s
            });
        })();
    </script>
</body>
</html>
    """ <| FunScript.Compiler.compileWithoutReturn <@ App.main() @> 
    0
