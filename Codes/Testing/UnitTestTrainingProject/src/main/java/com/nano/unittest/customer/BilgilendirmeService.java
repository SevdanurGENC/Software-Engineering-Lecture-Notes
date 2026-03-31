package com.nano.unittest.customer;

import com.nano.unittest.customer.exception.MailServerUnavailableException;

public class BilgilendirmeService {
	
	public void yeniKayitMailGonder(Musteri musteri) {
		System.out.println("Mail Gonderildi.");
	}

	public void haftalikMailGonder() {
		throw new MailServerUnavailableException("Mail Server Hata Veriyor");		
	}

}
