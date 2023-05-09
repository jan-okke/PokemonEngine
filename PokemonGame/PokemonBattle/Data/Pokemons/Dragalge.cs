using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dragalge : Pokemon
{
	public override string Name => "Dragalge";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Poisontouch() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(65, 75, 90, 97, 123, 44);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Smokescreen(), new Moves.Acid(), new Moves.Watergun() },
		[15] = new List<Move>() { new Moves.Tailwhip() },
		[20] = new List<Move>() { new Moves.Doubleteam() },
		[25] = new List<Move>() { new Moves.Poisontail() },
		[30] = new List<Move>() { new Moves.Waterpulse() },
		[35] = new List<Move>() { new Moves.Toxic() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[45] = new List<Move>() { new Moves.Aquatail() },
		[52] = new List<Move>() { new Moves.Sludgebomb() },
		[59] = new List<Move>() { new Moves.Hydropump() },
		[66] = new List<Move>() { new Moves.Outrage() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Dive(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterfall() };
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