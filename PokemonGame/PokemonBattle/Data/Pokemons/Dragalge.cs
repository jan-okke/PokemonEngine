using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dragalge : Pokemon
	{
		public override string Name => "Dragalge";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Poisontouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(65, 75, 90, 97, 123, 44);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Smokescreen(), new Acid(), new Watergun() },
			[15] = new List<Move>() { new Tailwhip() },
			[20] = new List<Move>() { new Doubleteam() },
			[25] = new List<Move>() { new Poisontail() },
			[30] = new List<Move>() { new Waterpulse() },
			[35] = new List<Move>() { new Toxic() },
			[40] = new List<Move>() { new Dragonpulse() },
			[45] = new List<Move>() { new Aquatail() },
			[52] = new List<Move>() { new Sludgebomb() },
			[59] = new List<Move>() { new Hydropump() },
			[66] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Dive(), new Dracometeor(), new Dragonpulse(), new Endure(), new Facade(), new Flipturn(), new Focusblast(), new Gigaimpact(), new Gunkshot(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icywind(), new Irontail(), new Outrage(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Thunder(), new Thunderbolt(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterfall() };
		public override int Weight => 815;
		public override int ExpYield => 173;
		public override int CatchRate => 55;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}