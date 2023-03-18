using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mrrime : Pokemon
	{
		public override string Name => "Mr. Rime";
		public override List<Ability> AvailableAbilities => new() {new Tangledfeet(), new Screencleaner() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icebody() };
		public override Stats BaseStats => new Stats(80, 85, 75, 110, 100, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Faketears(), new Slackoff(), new Afteryou(), new Block(), new Copycat(), new Encore(), new Roleplay(), new Protect(), new Recycle(), new Mimic(), new Lightscreen(), new Reflect(), new Safeguard(), new Dazzlinggleam(), new Mistyterrain(), new Pound(), new Rapidspin(), new Batonpass(), new Iceshard() },
			[12] = new List<Move>() { new Confusion() },
			[16] = new List<Move>() { new Allyswitch() },
			[20] = new List<Move>() { new Icywind() },
			[24] = new List<Move>() { new Doublekick() },
			[28] = new List<Move>() { new Psybeam() },
			[32] = new List<Move>() { new Hypnosis() },
			[36] = new List<Move>() { new Mirrorcoat() },
			[40] = new List<Move>() { new Suckerpunch() },
			[44] = new List<Move>() { new Freezedry() },
			[48] = new List<Move>() { new Psychic() },
			[52] = new List<Move>() { new Teeterdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Avalanche(), new Batonpass(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Fling(), new Focusblast(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Irondefense(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Metronome(), new Mistyterrain(), new Nastyplot(), new Payback(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Screech(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Storedpower(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Tripleaxel(), new Uproar(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Confuseray(), new Fakeout(), new Hypnosis(), new Powersplit(), new Tickle() };
		public override int Weight => 582;
		public override int ExpYield => 182;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}