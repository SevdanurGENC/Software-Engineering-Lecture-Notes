package com.nano.unittest.customer;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertTrue;

import org.junit.*;
import org.junit.rules.ExpectedException;
import static com.googlecode.catchexception.CatchException.catchException;
import static com.googlecode.catchexception.CatchException.caughtException;
import com.nano.unittest.customer.exception.MailServerUnavailableException;

public class ExceptionTest {
	
	private BilgilendirmeService bilgilendirmeService = new BilgilendirmeService();
	
	/**
     * Tray catch ile hatayı yakalıyoruz bu hatanın hangi tipte ve ne hatası oldunu doğruluyoruz.
     */
	
	@Test
	public void testTryCatchException() {
		try {
			bilgilendirmeService.haftalikMailGonder();			
		} catch (Exception ex) {
			assertTrue(ex instanceof MailServerUnavailableException);
			assertEquals("Mail Server Hata Veriyor", ex.getMessage());
		}
	}
	
	/**
     *Bu metodu çalıştırdığımda hata bekliyorum ve bu hata expected ekindeki verdiğim hata olması gerekiyor.
     * Hata mesajını bununla kontrol edemeyız
     */
	@Test(expected = MailServerUnavailableException.class)
	public void testExceptedException() throws Exception{
		bilgilendirmeService.haftalikMailGonder();
	}

	/**
     * Rule anatasyonunu kullanıyoruz. Bunun ile beklenilen hataları belirtiyoruz sonra servisi çağrıyoruz.Sonradan junit tarafından kontrol ediliyor.
     */
	@Rule
	public ExpectedException thrown = ExpectedException.none();
	
	@Test
	public void testRuleException() throws Exception{
		thrown.expect(MailServerUnavailableException.class);
		thrown.expectMessage("Mail Server Hata Veriyor");
		bilgilendirmeService.haftalikMailGonder();;

	}
	
	/**CatchException adındaki farklı bir kütüphane.
     * catchException ile servis çağrılır ardından  yakalanan hatayı istediğimiz
     * şekilde kullanıp sorguları gerçekleştirebiliriz.
     */
	
	@Test
	public void testCatchExceptionFramework() throws Exception{
		
		catchException(bilgilendirmeService).haftalikMailGonder();
		
		assertTrue(caughtException() instanceof MailServerUnavailableException);
		assertEquals("Mail Server Hata Veriyor", caughtException().getMessage());
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
