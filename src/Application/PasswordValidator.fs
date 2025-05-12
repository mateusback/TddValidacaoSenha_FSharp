
module Application.PasswordValidator

let validatePassword password =
    [
        if password.Length < 8 then Some "Senha muito curta" else None
        if not (Seq.exists System.Char.IsUpper password) then Some "Deve conter letra maiúscula" else None
        if not (Seq.exists System.Char.IsDigit password) then Some "Deve conter número" else None
    ]
    |> List.choose id
