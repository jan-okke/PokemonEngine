using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nidoqueen : Pokemon
	{
		public override string Name => "Nidoqueen";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Rivalry() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(90, 92, 87, 76, 75, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Superpower() },
			[1] = new List<Move>() { new Sludgewave(), new Superpower(), new Furyswipes(), new Toxicspikes(), new Doublekick(), new Bite(), new Helpinghand(), new Toxic(), new Flatter(), new Crunch(), new Earthpower(), new Growl(), new Poisonsting(), new Scratch(), new Tailwhip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Avalanche(), new Beatup(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Charm(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dragonpulse(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hex(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Megakick(), new Megapunch(), new Mudshot(), new Outrage(), new Payday(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockblast(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Torment(), new Toxic(), new Toxicspikes(), new Uproar(), new Venomdrench(), new Venoshock(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 600;
		public override int ExpYield => 253;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}