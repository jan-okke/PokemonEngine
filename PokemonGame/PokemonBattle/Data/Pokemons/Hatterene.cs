using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hatterene : Pokemon
	{
		public override string Name => "Hatterene";
		public override List<Ability> AvailableAbilities => new() {new Healer(), new Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicbounce() };
		public override Stats BaseStats => new Stats(57, 90, 95, 29, 136, 103);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Psychocut() },
			[1] = new List<Move>() { new Psychocut(), new Brutalswing(), new Confusion(), new Playnice(), new Lifedew(), new Disarmingvoice() },
			[15] = new List<Move>() { new Aromatherapy() },
			[20] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Healpulse() },
			[30] = new List<Move>() { new Dazzlinggleam() },
			[37] = new List<Move>() { new Calmmind() },
			[46] = new List<Move>() { new Psychic() },
			[55] = new List<Move>() { new Healingwish() },
			[64] = new List<Move>() { new Magicpowder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Brutalswing(), new Calmmind(), new Charm(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Expandingforce(), new Facade(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Magicroom(), new Mistyexplosion(), new Mysticalfire(), new Playrough(), new Powerswap(), new Powerwhip(), new Protect(), new Psychic(), new Psychocut(), new Psyshock(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shadowclaw(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Swordsdance(), new Thunderwave(), new Trickroom(), new Wonderroom() };
		public override int Weight => 51;
		public override int ExpYield => 255;
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