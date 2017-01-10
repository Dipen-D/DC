# DC


Stateless REST APIs

Account creation (Register):
Request:
POST https://localhost/api/Account/Register
Header:
Content-Type: application/json
Body:
{
  "Email": "martin.carianni@dreamcatcher.com",
  "Password": "mC!23b56",
  "ConfirmPassword": "mC!23b56"
}

Response:
HTTP Status: 200 (i.e. OK)


Get access token:
Request:
POST https://localhost/Token
Header:
Content-Type: application/x-www-form-urlencoded
Body Parameters:
"grant_type": "password",
"username": "martin.carianni@dreamcatcher.com",
"password": "mC!23b56"

Response:
{
 "access_token": "6WM560w_UrNMSRlsL2Ymun3jRvgDLz9dWMZ7KRM9FYBeRQbznhcq-mLD9hO0G1j5XNSF7JvXXYhMhjEnvc20Ou3mXOZiInN-x9C3cA_YyNv0QEKiyQ7StrRCSloAW9KTaPx_tEa5Cx7EQeqNhzRLsqKzgwBkSQAFcdMdXd5235JTaleiFPWUt4md71fIXo7GkYu9ddCUsTJb23LFQXJvvwmxeoF3EqRxmDsjAYcNNGPQmLdOKmGiuqGuLD9dDNMUizpnZX_4VXDffw2H8T-XUkM_4myabPY4Dbu0v-O8rS17qfl_VXuYN3kAk2EK-7aru_9IS63zOuoTswWBU86sexRBy_gcIoy59OuU8TGIzEjpBpoptMN2cihD06lpNdwZZVUHE257VJFkDSsXH94ukRQyUqhW-LHc-Otrb8JAhsqORaXKhAfBiRqHyPMv3uwYt7zyGmk_VdEBWVvXRXrPh9LEpIQqavSTtD_-QbWr65rilVy8WG9kyeRS09m_6eIz",
 "token_type": "bearer",
 "expires_in": 1209599,
 "userName": "martin.carianni@dreamcatcher.com",
 ".issued": "Mon, 09 Jan 2017 11:36:51 GMT",
 ".expires": "Mon, 23 Jan 2017 11:36:51 GMT"
}


Get components and thumbs URL:
Request:
POST https://localhost/api/Component/GetComponentsAndThumbsURL
Headers:
Authorization:
Bearer 6WM560w_UrNMSRlsL2Ymun3jRvgDLz9dWMZ7KRM9FYBeRQbznhcq-mLD9hO0G1j5XNSF7JvXXYhMhjEnvc20Ou3mXOZiInN-x9C3cA_YyNv0QEKiyQ7StrRCSloAW9KTaPx_tEa5Cx7EQeqNhzRLsqKzgwBkSQAFcdMdXd5235JTaleiFPWUt4md71fIXo7GkYu9ddCUsTJb23LFQXJvvwmxeoF3EqRxmDsjAYcNNGPQmLdOKmGiuqGuLD9dDNMUizpnZX_4VXDffw2H8T-XUkM_4myabPY4Dbu0v-O8rS17qfl_VXuYN3kAk2EK-7aru_9IS63zOuoTswWBU86sexRBy_gcIoy59OuU8TGIzEjpBpoptMN2cihD06lpNdwZZVUHE257VJFkDSsXH94ukRQyUqhW-LHc-Otrb8JAhsqORaXKhAfBiRqHyPMv3uwYt7zyGmk_VdEBWVvXRXrPh9LEpIQqavSTtD_-QbWr65rilVy8WG9kyeRS09m_6eIz
Content-Type: application/json
Body:
{
  "PakFileType": "Windows"
}

Example Response:
{
  "Data": {
    “Components”: [
      {
        “Id”: 1,
        “Name”: “Chair”,
      },
      {
        “Id”: 2,
        “Name”: “Sofa”,
      }
    ]
  }
}
