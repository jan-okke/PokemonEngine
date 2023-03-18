using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nidoking : Pokemon
	{
		public override string Name => "Nidoking";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Rivalry() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(81, 102, 77, 85, 75, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Megahorn() },
			[1] = new List<Move>() { new Moves.Sludgewave(), new Moves.Megahorn(), new Moves.Furyattack(), new Moves.Toxicspikes(), new Moves.Doublekick(), new Moves.Hornattack(), new Moves.Helpinghand(), new Moves.Toxic(), new Moves.Flatter(), new Moves.Poisonjab(), new Moves.Earthpower(), new Moves.Leer(), new Moves.Poisonsting(), new Moves.Peck(), new Moves.Focusenergy() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Megahorn(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Payday(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterpulse(), new Moves.Whirlpool() };
		public override int Weight => 620;
		public override int ExpYield => 253;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}