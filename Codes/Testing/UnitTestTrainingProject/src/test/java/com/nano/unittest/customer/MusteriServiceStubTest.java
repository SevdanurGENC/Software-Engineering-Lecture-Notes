package com.nano.unittest.customer;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertNull;
import static org.junit.Assert.assertTrue;

import org.junit.*;
import org.mockito.Mockito;

public class MusteriServiceStubTest {
	
	private MusteriService musteriService; 
	private MusteriRepositoryStub musteriRepository;
	private BilgilendirmeService bilgilendirmeService;
	
	@Before
	public void setUp() throws Exception {
		musteriService = new MusteriService(); 
		bilgilendirmeService = Mockito.mock(BilgilendirmeService.class);
		musteriRepository = new MusteriRepositoryStub();
		musteriService.setMusteriRepository(musteriRepository);
		musteriService.setBilgilendirmeService(bilgilendirmeService);
	}
	
	@After
	public void after() throws Exception {
		musteriRepository.herseyiSil();
	}
	
	@Test
	public void testMusteriKaydet() throws Exception { 
		Musteri musteri = new Musteri(1234);
		musteriService.musteriKaydet(musteri); 
		//assertTrue(musteriRepository.getMusterListesi().containsValue(musteri));
		assertEquals(musteri, musteriRepository.bul(musteri.getId()));
	}  
	
	@Test
	public void testMusteriSil() throws Exception {
		
		//testMusteriKaydet(); 
		//assertNotNull(musteriRepository.bul(1234)); 
		musteriService.musteriKaydet(new Musteri(1234));
		musteriService.musteriSil(1234); 
		assertNull(musteriRepository.bul(1234));


	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
