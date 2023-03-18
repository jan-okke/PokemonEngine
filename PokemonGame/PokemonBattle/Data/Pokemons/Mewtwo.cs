using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mewtwo : Pokemon
	{
		public override string Name => "Mewtwo";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(106, 110, 90, 154, 90, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lifedew(), new Laserfocus(), new Disable(), new Confusion(), new Swift() },
			[8] = new List<Move>() { new Ancientpower() },
			[16] = new List<Move>() { new Psychocut() },
			[24] = new List<Move>() { new Safeguard() },
			[32] = new List<Move>() { new Amnesia() },
			[40] = new List<Move>() { new Aurasphere() },
			[48] = new List<Move>() { new Psychic() },
			[56] = new List<Move>() { new Powerswap(), new Guardswap() },
			[64] = new List<Move>() { new Mist() },
			[72] = new List<Move>() { new Psystrike() },
			[80] = new List<Move>() { new Recover() },
			[88] = new List<Move>() { new Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Allyswitch(), new Amnesia(), new Aurasphere(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Dive(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Earthquake(), new Electroball(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Hail(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magicroom(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Payday(), new Poisonjab(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Stoneedge(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Triattack(), new Trick(), new Trickroom(), new Waterpulse(), new Willowisp(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 1220;
		public override int ExpYield => 340;
		public override int CatchRate => 3;
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