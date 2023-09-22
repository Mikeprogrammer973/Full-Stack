
import Validator from "./validator"

class EmailValidator implements Validator 
{
    isValid(s: string): boolean {
        const emailRegEx = /\S+@\S+\.\S+/
        return emailRegEx.test(s)
    }
}

export {EmailValidator}
