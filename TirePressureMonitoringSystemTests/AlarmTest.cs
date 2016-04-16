using NUnit.Framework;
using TirePressureMonitoringSystem;

namespace TirePressureMonitoringSystemTests
{
    [TestFixture]
    public class AlarmTest
    {
        [Test]
        public void Should_do_when_conditions()
        {
            var alarm = new Alarm();
            Assert.AreEqual(false, alarm.AlarmOn);
        }
    }
}