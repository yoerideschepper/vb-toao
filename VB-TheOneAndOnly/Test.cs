using System.Collections.Generic;
using Xunit;

namespace VB_TheOneAndOnly.BusinessLogic
{
    public class Test
    {
        
   

        
        [Fact]
        public void Checksum1()
        {
            Checksum ck = new Checksum();
            
            int[] input = { 1,1,2,2};
            int result = 3;

           var calculation= ck.CalculateChecksum(input);
            
            Assert.Equal(result, calculation);

        }
        
        
        [Fact]
        public void Checksum2()
        {
            string input = "91212129";
            int result = 9;
            Checksum ck = new Checksum();
            var calc = ck.CalculateChecksum(  ck.FromStringToIntArray(input));
            Assert.Equal(result, calc);
        }
        
        [Fact]
        public void Checksum3()
        {
            string input = "1234";
            int result = 0;
            Checksum ck = new Checksum();
            var calc = ck.CalculateChecksum(  ck.FromStringToIntArray(input));
            Assert.Equal(result, calc);
        }
        
        [Fact]
        public void Checksum4()
        {
            string input = "1111";
            int result = 4;
            Checksum ck = new Checksum();
            var calc = ck.CalculateChecksum(  ck.FromStringToIntArray(input));
            Assert.Equal(result, calc);
        }
        
        
        
        [Fact]
        public void ChecksumFromTechTest()
        {
            string input = "7385764686251444473997915123782972536343732657517834671759462795461213782428342931896181695578996274321317419242359534783957372932953774336338118488967172727651862498838195317654289797558683458511126996217953322817229372373455862177844478443391835484591525235651863464891177927244954925827786799436536592561374269299474738321293575385899438446558569241236278779779983587912431395475244796538888373287186921647426866237756737342731976763959499149996315591584716122199183295277439872911371313924594486766479438544417416529743495114819825984524437367225234184772617942525954961136976875325182725754768372684531972614455134523596338355374444273522115362238734383164778129376628621497662965456761631796178353599629887665939521892447361219479646483978798392716119793282717739524897385958273726776318154977675546287789874265339688753977185129334929715486381875286278528247696464162297691698154712775589541945263574897266575996455547625537947927972497979333932115165151462742216327321116291372396585618664475715321298122335789262942284571328414569375464386446824882551918843185195829547373915482687534432942778312542752798313434628498295216692646713137244198123219531693559848915834623825919191532658735422176965451741869666714874158492556445954852299161868651448123825821775363219246244515946392686275545561989355573946924767442253465342753995764791927951158771231944177692469531494559697911176613943396258141822244578457498361352381518166587583342233816989329544415621127397996723997397219676486966684729653763525768655324443991129862129181215339947555257279592921258246646215764736698583211625887436176149251356452358211458343439374688341116529726972434697324734525114192229641464227986582845477741747787673588848439713619326889624326944553386782821633538775371915973899959295232927996742218926514374168947582441892731462993481877277714436887597223871881149693228928442427611664655772333471893735932419937832937953495929514837663883938416644387342825836673733778119481514427512453357628396666791547531814844176342696362416842993761919369994779897357348334197721735231299249116477";
            int result = 1171;
            Checksum ck = new Checksum();
            var calc = ck.CalculateChecksum(  ck.FromStringToIntArray(input));
            Assert.Equal(result, calc);
        }
        
        
         [Fact]
        public void ChecksumFromTechTestByHalf()
        {
            string input = "7385764686251444473997915123782972536343732657517834671759462795461213782428342931896181695578996274321317419242359534783957372932953774336338118488967172727651862498838195317654289797558683458511126996217953322817229372373455862177844478443391835484591525235651863464891177927244954925827786799436536592561374269299474738321293575385899438446558569241236278779779983587912431395475244796538888373287186921647426866237756737342731976763959499149996315591584716122199183295277439872911371313924594486766479438544417416529743495114819825984524437367225234184772617942525954961136976875325182725754768372684531972614455134523596338355374444273522115362238734383164778129376628621497662965456761631796178353599629887665939521892447361219479646483978798392716119793282717739524897385958273726776318154977675546287789874265339688753977185129334929715486381875286278528247696464162297691698154712775589541945263574897266575996455547625537947927972497979333932115165151462742216327321116291372396585618664475715321298122335789262942284571328414569375464386446824882551918843185195829547373915482687534432942778312542752798313434628498295216692646713137244198123219531693559848915834623825919191532658735422176965451741869666714874158492556445954852299161868651448123825821775363219246244515946392686275545561989355573946924767442253465342753995764791927951158771231944177692469531494559697911176613943396258141822244578457498361352381518166587583342233816989329544415621127397996723997397219676486966684729653763525768655324443991129862129181215339947555257279592921258246646215764736698583211625887436176149251356452358211458343439374688341116529726972434697324734525114192229641464227986582845477741747787673588848439713619326889624326944553386782821633538775371915973899959295232927996742218926514374168947582441892731462993481877277714436887597223871881149693228928442427611664655772333471893735932419937832937953495929514837663883938416644387342825836673733778119481514427512453357628396666791547531814844176342696362416842993761919369994779897357348334197721735231299249116477";
            int result = 1024;
            Checksum ck = new Checksum();
            var calc = ck.CalculateChecksumByHalf(  ck.FromStringToIntArray(input));
            Assert.Equal(result, calc);
        }
        
        
        [Fact]
        public void Streamz()
        {
            Stream st = new Stream();
            int expectedScore = 13154;
            var stream = st.ReadStream();
            int score = st.CalculateScore(stream);
            
            Assert.Equal(expectedScore, score);
            
        }
        
        [Fact]
        public void Streamz1()
        {
            Stream st = new Stream();
            int expectedScore = 1;
            var stream = "{}";
            int score = st.CalculateScore(stream);
            
            Assert.Equal(expectedScore, score);
            
        }
        
        [Fact]
        public void Streamz2()
        {
            Stream st = new Stream();
            int expectedScore = 5;
            var stream = "{{},{}}";
            int score = st.CalculateScore(stream);
            
            Assert.Equal(expectedScore, score);
            
        }
        
        [Fact]
        public void Streamz3()
        {
            Stream st = new Stream();
            int expectedScore = 1;
            var stream = "{<a>,<a>,<a>,<a>}";
            int score = st.CalculateScore(stream);
            
            Assert.Equal(expectedScore, score);
            
        }
        
        [Fact]
        public void StreamzEscaped()
        {
            Stream st = new Stream();
            int expectedScore = 9;
            var stream = "{{<!!>},{<!!>},{<!!>},{<!!>}} ";
            int score = st.CalculateScore(stream);
            
            Assert.Equal(expectedScore, score);
            
        }
        
        
        
        
        [Fact]
        public void Fractal()
        {

            var rule1 = "../.# => ##./#../...";
            var rule2 = ".#./..#/### => #..#/..../..../#..#";
            
            Fractal fr = new Fractal();
            
            
            
            
            
            //Assert.Equal(expectedScore, score);

        }
        
        
         
        [Fact]
        public void ReadingFiles()
        {

            FileReader fr = new FileReader();
            Stream st = new Stream();
            string inByName =fr.ReadStreamByName("stream");
            string stream = st.ReadStream();
            Assert.Equal(stream, inByName);

        }
        
        [Fact]
        public void CalculatingSignalDistortionOne()
        {
            string signal = "acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab | cdfeb fcadb cdfeb cdbaf";
            SegmentedDisplay sd = new SegmentedDisplay();
            sd.SplitSignal(signal);
           // sd.MapInputSignal();
           // sd.CalculateEndNumber();
            
            



            //  Assert.Equal(stream, inByName);

        }
        
        [Fact]
        public void MapSignalToNumber()
        {
            string signal = "acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab";
            string outputSignal = "cdfeb fcadb cdfeb cdbaf";
            
            SegmentedDisplay sd = new SegmentedDisplay();
            
            string[] signalArray = signal.Split(' ');
            
            
            sd.MapInputSignal(signalArray);



            //  Assert.Equal(stream, inByName);

        }
        
        [Fact]
        public void CheckSignalForNubmer()
        {
            string signal = "acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab";
            string outputSignal = "cdfeb fcadb cdfeb cdbaf";
            
            SegmentedDisplay sd = new SegmentedDisplay();
            
            string[] signalArray = signal.Split(' ');
            var map = sd.MapInputSignal(signalArray);


            Assert.Equal(1, map["ab"]);

        }

        [Fact]
        public void CalculateResultSignal()
        {
            
            
            SegmentedDisplay sd = new SegmentedDisplay();
            
            string[] outputSignal = { "cdfeb", "fcadb" };
            Dictionary<string, int> map = new Dictionary<string, int>
            {
                { "cdfeb",  5 },
                { "fcadb", 3 }
            };
            
            var restult = sd.CalculateEndNumber(map, outputSignal);
            
            
            Assert.Equal("53", restult);
        }





    }
    
    
    
}