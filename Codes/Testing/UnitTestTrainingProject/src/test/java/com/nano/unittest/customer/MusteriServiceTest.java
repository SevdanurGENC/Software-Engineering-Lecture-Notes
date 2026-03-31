package com.nano.unittest.customer;

import org.junit.*;
import org.mockito.Mockito;

public class MusteriServiceTest {
	
	private MusteriService musteriService;
	private MusteriRepository musteriRepository;
	private BilgilendirmeService bilgilendirmeService;
	
	@Before
	public void setUp() throws Exception {
		musteriService = new MusteriService();
		//musteriRepository = new MusteriRepository();
		musteriRepository = Mockito.mock(MusteriRepository.class);
		//bilgilendirmeService = new BilgilendirmeService();
		bilgilendirmeService = Mockito.mock(BilgilendirmeService.class);
		musteriService.setMusteriRepository(musteriRepository);
		musteriService.setBilgilendirmeService(bilgilendirmeService);
	}
	
	@Test
	public void testMusteriKaydet() throws Exception {
		Musteri musteri = new Musteri();
		musteriService.musteriKaydet(musteri);
		
		Mockito.verify(bilgilendirmeService).yeniKayitMailGonder(musteri);
		Mockito.verify(musteriRepository).kaydet(musteri);
		
		
	}

}
