using Problems.Medium;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class MeetingRoomIITests
    {
        [Test]
        public void MinMeetingRooms_Case1_Returns2()
        {
            // Arrange
            int[][] intervals =
            [
                [0, 30],
                [5, 10],
                [15, 20]
            ];
            int expected = 2;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_Case2_Returns1()
        {
            // Arrange
            int[][] intervals =
            [
                [0, 4],
                [5, 10]
            ];
            int expected = 1;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_Case3_Returns3()
        {
            // Arrange
            int[][] intervals =
            [
                [1, 5],
                [3, 6],
                [0, 4],
                [5, 10]
            ];
            int expected = 3;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_NoMeetings_Returns0()
        {
            // Arrange
            int[][] intervals = [];
            int expected = 0;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_SingleMeeting_Returns1()
        {
            // Arrange
            int[][] intervals =
            [
                [10, 20]
            ];
            int expected = 1;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_MeetingsWithSameStartTime_ReturnsCorrectNumber()
        {
            // Arrange
            int[][] intervals =
            [
                [10, 20],
                [10, 25],
                [10, 30]
            ];
            int expected = 3;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_MeetingsWithSameEndTime_ReturnsCorrectNumber()
        {
            // Arrange
            int[][] intervals =
            [
                [5, 15],
                [10, 15],
                [12, 15]
            ];
            int expected = 3;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_NullIntervals_Returns0()
        {
            // Arrange
            int[][]? intervals = null;
            int expected = 0;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals: intervals!);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MinMeetingRooms_OverlappingAndNonOverlappingMix_ReturnsCorrectNumber()
        {
            // Arrange
            int[][] intervals =
            [
                [1, 4],
                [2, 5],
                [7, 9],
                [3, 6],
                [10, 11]
            ];
            int expected = 3;

            // Act
            int actual = MeetingRoomII.MinMeetingRooms(intervals);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
