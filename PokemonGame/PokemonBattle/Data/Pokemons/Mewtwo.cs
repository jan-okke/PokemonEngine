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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
		public override Stats BaseStats => new Stats(106, 110, 90, 154, 90, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Lifedew(), new Moves.Laserfocus(), new Moves.Disable(), new Moves.Confusion(), new Moves.Swift() },
			[8] = new List<Move>() { new Moves.Ancientpower() },
			[16] = new List<Move>() { new Moves.Psychocut() },
			[24] = new List<Move>() { new Moves.Safeguard() },
			[32] = new List<Move>() { new Moves.Amnesia() },
			[40] = new List<Move>() { new Moves.Aurasphere() },
			[48] = new List<Move>() { new Moves.Psychic() },
			[56] = new List<Move>() { new Moves.Powerswap(), new Moves.Guardswap() },
			[64] = new List<Move>() { new Moves.Mist() },
			[72] = new List<Move>() { new Moves.Psystrike() },
			[80] = new List<Move>() { new Moves.Recover() },
			[88] = new List<Move>() { new Moves.Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Aurasphere(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Electroball(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Payday(), new Moves.Poisonjab(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterpulse(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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