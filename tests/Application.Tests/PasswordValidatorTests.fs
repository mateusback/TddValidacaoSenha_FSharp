
module Application.Tests.PasswordValidatorTests

open Expecto
open Application.PasswordValidator

[<Tests>]
let tests =
  testList "Validação de Senha" [
    testCase "Senha válida" <| fun _ ->
      let result = validatePassword "Senha123"
      Expect.isEmpty result "Senha deveria ser válida"

    testCase "Senha sem número" <| fun _ ->
      let result = validatePassword "Senha"
      Expect.contains result "Deve conter número" "Deveria acusar falta de número"
  ]
